/*
 * Created by SharpDevelop.
 * User: josbaril
 * Date: 2014-08-28
 * Time: 16:11
 * 
 * 
 * 
 * TODO Ajout d'une option pour force l'arret lorsqu'il est impossible de lire le fichier de configuration
 * TODO Tester avec une mauvaise ligne de commande
 * TODO Tester avec un mauvais fichier de configuration
 * 
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CommandLine.Utility;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace FermeturePC
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmFermeture : Form
	{
		public struct DesParametres
		{
			public string titre;
			public string description;
			public int delaiMaximum;
			public int delaiMinimum;
			public int delaiAvertissement;
			public bool obligatoire;
			public string fichierXML;
			public string id;
			public int auDessus;
			public string valeurBouton1;
			public string texteBouton1;
			public string valeurBouton2;
			public string texteBouton2;
			public string valeurBouton3;
			public string texteBouton3;
			public string texteBoutons;
			public string texteAnnuler;
		}
		private XmlDocument configuration;
		
		public static bool messageOuvert = false;
		public static DateTime heureFermeture;
		public static int tempsRajouter = 0;
		public static bool formEstAffiche = true;
		public static int tempsBtn1;
		public static int tempsBtn2;
		public static int tempsBtn3;
		public static string textBtn1;
		public static string textBtn2;
		public static string textBtn3;
		public static bool fermer = false;
		Timer timerFermeture;
		public DesParametres listeParametres;
		
		public frmFermeture(string[] Args)
		{
			InitializeComponent();
			bool valeurDefaut = ParametresParDefauts();
			bool configOK = ChargerParametres(Args);
			if(valeurDefaut && configOK) // Si le chargement de la configuration s'est bien passé...
			{
				fermer = true;
			}
			else // Sinon, ne ferme pas l'ordinateur
			{
				fermer = false;
			}
			// Titre de la fenêtre
			Text = listeParametres.titre;
			// Message de description
			lblDescription.Text = listeParametres.description;
			// Valeurs et textes des boutons qui retardent la fermeture
			tempsBtn1 = Convert.ToInt16(listeParametres.valeurBouton1);
			btnAjouter10.Text = listeParametres.texteBouton1;
			tempsBtn2 = Convert.ToInt16(listeParametres.valeurBouton2);
			btnAjouter20.Text = listeParametres.texteBouton2;
			tempsBtn3 = Convert.ToInt16(listeParametres.valeurBouton3);
			btnAjouter30.Text = listeParametres.texteBouton3;
			// Définit si au dessus des autres fenêtre
			if(listeParametres.auDessus.ToString() == "1") { this.TopMost = true; }
			// Description des boutons d'ajout de temps
			lblAjouterTemps.Text = listeParametres.texteBoutons;
			// Description du bouton <annuler la fermeture>
			lblAnnulerFermeture.Text = listeParametres.texteAnnuler;
			// Affichage du temps restant avant la fermeture
			heureFermeture = DateTime.Now.AddSeconds(listeParametres.delaiMinimum);
			timerFermeture = new Timer();
			timerFermeture.Tick += new System.EventHandler(this.TimerFermetureTick);
			timerFermeture.Start();
		}
		
		/// <summary>
		/// Appliquer les valeurs par défauts des paramètres
		/// </summary>
		/// <returns></returns>
		private bool ParametresParDefauts()
		{
			try
			{
				listeParametres.titre = "Fermeture des ordinateurs pédagogiques";
				listeParametres.description = "Pour économiser de l'énergie, cet ordinateur va être arrêté pour la nuit. Pour éviter tout désagrément, nous vous recommandons fortement de sauvegarder votre travail en cours. Merci de votre collaboration.";
				listeParametres.delaiMaximum = 99999;
				listeParametres.delaiMinimum = 60;
				listeParametres.delaiAvertissement = 30;
				listeParametres.obligatoire = true;
				listeParametres.fichierXML = "Config.xml";
				listeParametres.id = "0001";
				listeParametres.auDessus = 1;
				listeParametres.valeurBouton1 = "10";
				listeParametres.texteBouton1 = "10 secondes";
				listeParametres.valeurBouton2 = "20";
				listeParametres.texteBouton2 = "20 secondes";
				listeParametres.valeurBouton3 = "30";
				listeParametres.texteBouton3 = "30 secondes";
				listeParametres.texteBoutons = "Ajouter du temps pour retarder l'arrêt";
				listeParametres.texteAnnuler = "Annuler la fermeture et retourner au bureau";
			}
			catch(Exception e)
			{
				return false;
			}
			return true;
		}
		
		/// <summary>
		/// Valide et charge les valeurs des paramètres
		/// </summary>
		private bool ChargerParametres(string[] m_args)
		{
			try
			{
				Arguments arguments = new Arguments(m_args);
				listeParametres = new DesParametres();
				if(arguments["ConfigXML"] != null) { listeParametres.fichierXML = arguments["ConfigXML"]; }
				if(arguments["Id"] != null) { listeParametres.id = arguments["Id"]; }
				configuration = new XmlDocument();
				FileInfo fi = new FileInfo(listeParametres.fichierXML);
				if(fi.Exists)
				{
					configuration.Load(listeParametres.fichierXML);
					XmlNodeList m_config = configuration.GetElementsByTagName("Configuration");
			        for (int i = 0; i < m_config.Count; i++)
			        {
			        	XmlNode uneConfig = m_config[i];
			        	if(uneConfig["Id"].InnerText == listeParametres.id)
			        	{
			        		XmlNode param = uneConfig["Parametres"];
			        		if(param["Titre"].InnerText != null) { listeParametres.titre = param["Titre"].InnerText; }
			        		if(param["Message"].InnerText != null) { listeParametres.description = param["Message"].InnerText; }
			        		if(param["DelaiDepart"].InnerText != null) { listeParametres.delaiMinimum = Convert.ToInt32(param["DelaiDepart"].InnerText); }
			        		if(param["DelaiAvertissement"].InnerText != null) { listeParametres.delaiAvertissement = Convert.ToInt32(param["DelaiAvertissement"].InnerText); }
			        		if(param["DelaiMaximum"].InnerText != null) { listeParametres.delaiMaximum = Convert.ToInt32(param["DelaiMaximum"].InnerText); }
							if(param["ValeurBouton1"].InnerText != null) { listeParametres.valeurBouton1 = param["ValeurBouton1"].InnerText; }
							if(param["TexteBouton1"].InnerText != null) { listeParametres.texteBouton1 = param["TexteBouton1"].InnerText; }
							if(param["ValeurBouton2"].InnerText != null) { listeParametres.valeurBouton2 = param["ValeurBouton2"].InnerText; }
							if(param["TexteBouton2"].InnerText != null) { listeParametres.texteBouton2 = param["TexteBouton2"].InnerText; }
							if(param["ValeurBouton3"].InnerText != null) { listeParametres.valeurBouton3 = param["ValeurBouton3"].InnerText; }
							if(param["TexteBouton3"].InnerText != null) { listeParametres.texteBouton3 = param["TexteBouton3"].InnerText; }
							if(param["DescriptionBoutons"].InnerText != null) { listeParametres.texteBoutons = param["DescriptionBoutons"].InnerText; }
							if(param["DescriptionAnnuler"].InnerText != null) { listeParametres.texteAnnuler = param["DescriptionAnnuler"].InnerText; }
							if(param["AuDessusDeTout"].InnerText != null) { listeParametres.auDessus = Convert.ToInt32(param["AuDessusDeTout"].InnerText); }
			        	}
			        } 
				}
				else
				{
					return false;
				}
			}
			catch(Exception e)
			{
				return false;
			}
			if(listeParametres.titre == "") { return false; }
			return true;
		}
		
		/// <summary>
		/// Ferme le programme en cliquant sur le bouton annuler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnAnnulerClick(object sender, EventArgs e)
		{
			if(timerFermeture != null) { timerFermeture.Stop(); }
			this.Close();
		}
		/// <summary>
		/// Timer d'exécution pour le décompte
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TimerFermetureTick(object sender, EventArgs e)
		{
			TimeSpan time = heureFermeture - DateTime.Now;
			lblTempsRestant.Text = time.ToString(@"hh\:mm\:ss");
			lblTempsRestant.Refresh();
			if(time.TotalSeconds > 1 && time.TotalSeconds < listeParametres.delaiAvertissement)
			{
				this.WindowState = FormWindowState.Maximized;
				this.FormBorderStyle = FormBorderStyle.None;
				this.TopMost = true;
				pnlForm.Location = new Point(this.ClientSize.Width / 2 - pnlForm.Size.Width / 2, this.ClientSize.Height / 2 - pnlForm.Size.Height / 2);
				pnlForm.Anchor = AnchorStyles.None;
				cacherForm(false);
			}
			else
			{
				this.WindowState = FormWindowState.Normal;
				this.FormBorderStyle = FormBorderStyle.Fixed3D;
				this.TopMost = false;
			}
			if(time.TotalSeconds <= 0)
			{
				if(timerFermeture != null)
				{
					timerFermeture.Stop();
				}
				ControleurEtats.FermerOrdinateur(fermer);
				this.Close();
			}
		}
		/// <summary>
		/// Bouton qui permet d'ajouter 10 minutes au délai de fermeture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnAjouter10Click(object sender, EventArgs e)
		{
			int tmp = 0;
			int sec = 600;
			sec = (int)tempsBtn1;
			if((tempsRajouter + sec) <= listeParametres.delaiMaximum)
			{ 
				tempsRajouter += sec;
				heureFermeture = heureFermeture.AddSeconds(sec);
				cacherForm(true);
			}
			else
			{
				tmp = (listeParametres.delaiMaximum - tempsRajouter);
				heureFermeture = heureFermeture.AddSeconds(tmp);
				tempsRajouter = listeParametres.delaiMaximum;
			}
		}
		/// <summary>
		/// Bouton qui permet d'ajouter 20 minutes au délai de fermeture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnAjouter20Click(object sender, EventArgs e)
		{
			int tmp = 0;
			int sec = 1200;
			sec = (int)tempsBtn2;
			if((tempsRajouter + sec) <= listeParametres.delaiMaximum)
			{ 
				tempsRajouter += sec;
				heureFermeture = heureFermeture.AddSeconds(sec);
				cacherForm(true);
			}
			else
			{
				tmp = (listeParametres.delaiMaximum - tempsRajouter);
				heureFermeture = heureFermeture.AddSeconds(tmp);
				tempsRajouter = listeParametres.delaiMaximum;
			}
		}
		/// <summary>
		/// Bouton qui permet d'ajouter 30 minutes au délai de fermeture
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnAjouter30Click(object sender, EventArgs e)
		{
			int tmp = 0;
			int sec = 1800;
			sec = (int)tempsBtn3;
			if((tempsRajouter + sec) <= listeParametres.delaiMaximum)
			{ 
				tempsRajouter += sec;
				heureFermeture = heureFermeture.AddSeconds(sec);
				cacherForm(true);
			}
			else
			{
				tmp = (listeParametres.delaiMaximum - tempsRajouter);
				heureFermeture = heureFermeture.AddSeconds(tmp);
				tempsRajouter = listeParametres.delaiMaximum;
			}
		}
		/// <summary>
		/// Affiche les informations de l'ordinateur dans le controle
		/// </summary>
		void GetInformationsSysteme()
		{
			/*lblInfoOrdinateur.Text += "Adresses IP: ";
			List<string> listeIP = Get_InformationsWMI.GetAdresseIP("localhost");
			if(listeIP != null)
			{
				foreach(string ip in listeIP)
				{
					lblInfoOrdinateur.Text += ip.ToString();
					lblInfoOrdinateur.Text += " ";
				}
				lblInfoOrdinateur.Text += Environment.NewLine + "Nom: ";
				lblInfoOrdinateur.Text += Get_InformationsWMI.GetComputerName("localhost") + Environment.NewLine;
				ObjInfosOrdinateur infos = Get_InformationsWMI.GetModele("localhost");
				lblInfoOrdinateur.Text += "Fabricant: " + infos.fabricant + Environment.NewLine;
				lblInfoOrdinateur.Text += "Modèle: " + infos.modele + Environment.NewLine;
				lblInfoOrdinateur.Text += "Dernier démarrage: " + convertirWmiDate(Get_InformationsWMI.GetDernierDemarrage("localhost"));
			}*/
		}

		/// <summary>
		/// Cacher la form en la positionnant en dehors de l'écran
		/// </summary>
		void cacherForm(bool invisible)
		{
			if(invisible == true)
			{
				this.Location = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
				this.Refresh();
				formEstAffiche = false;
			}
			else
			{
				this.CenterToScreen();
				this.Refresh();
				formEstAffiche = true;
			}
		}
		
	}
}
