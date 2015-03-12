/*
 * Created by SharpDevelop.
 * User: josbaril
 * Date: 2014-08-28
 * Time: 16:11
 * 
 * 
 * 
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
	/// Formulaire principal de l'application
	/// </summary>
	public partial class frmFermeture : Form
	{
		/// <summary>
		/// Structure contenant les paramètres configurables depuis le fichiers XML
		/// </summary>
		public struct DesParametres
		{
			/// <summary>
			/// Titre de la fenêtre
			/// </summary>
			public string titre;
			/// <summary>
			/// Message afficher au centre du formulaire
			/// </summary>
			public string description;
			/// <summary>
			/// Délai maximal autorisé
			/// </summary>
			public int delaiMaximum;
			/// <summary>
			/// Délai initial lors du lancement de l'application
			/// </summary>
			public int delaiMinimum;
			/// <summary>
			/// Délai où le formulaire sera maximisé
			/// </summary>
			public int delaiAvertissement;
			/// <summary>
			/// Force ou non la fermeture lorsque le fichier xml n'est pas lisible
			/// </summary>
			public bool obligatoire;
			/// <summary>
			/// Chemin duquel lire le fichier XML
			/// </summary>
			public string fichierXML;
			/// <summary>
			/// Id de la configuration à lire
			/// </summary>
			public string id;
			/// <summary>
			/// Permet de définir si la fênetre apparait au dessus de tout
			/// </summary>
			public bool auDessus;
			/// <summary>
			/// Valeur du bouton d'ajout 1
			/// </summary>
			public string valeurBouton1;
			/// <summary>
			/// Texte du bouton d'ajout 1
			/// </summary>
			public string texteBouton1;
			/// <summary>
			/// Valeur du bouton d'ajout 2
			/// </summary>
			public string valeurBouton2;
			/// <summary>
			/// Texte du bouton d'ajout 2
			/// </summary>
			public string texteBouton2;
			/// <summary>
			/// Valeur du bouton d'ajout 3
			/// </summary>
			public string valeurBouton3;
			/// <summary>
			/// Texte du bouton d'ajout 3
			/// </summary>
			public string texteBouton3;
			/// <summary>
			/// Texte de description des boutons d'ajout de temps
			/// </summary>
			public string texteBoutons;
			/// <summary>
			/// Texte de description du bouton annuler
			/// </summary>
			public string texteAnnuler;
			/// <summary>
			/// Le logo à afficher sur le formulaire
			/// </summary>
			public string logo;
			/// <summary>
			/// Permet de forcer ou non la fermeture lorsqu'une session est verrouillé
			/// </summary>
			public bool ForcerFermetureSiVerrouille;
		}
		private XmlDocument configuration;
		/// <summary>
		/// Indique l'heure de fermeture
		/// </summary>
		public static DateTime heureFermeture;
		/// <summary>
		/// Indique le temps ajouté à l'heure de fermeture en ...
		/// </summary>
		public static int tempsRajouter = 0;
		/// <summary>
		/// Indique si le formulaire est maximisé
		/// </summary>
		public static bool formEstAffiche = true;
		/// <summary>
		/// Indique la valeur en unité de temps pour le bouton d'ajout 1
		/// </summary>
		public static int tempsBtn1;
		/// <summary>
		/// Indique la valeur en unité de temps pour le bouton d'ajout 2
		/// </summary>
		public static int tempsBtn2;
		/// <summary>
		/// Indique la valeur en unité de temps pour le bouton d'ajout 3
		/// </summary>
		public static int tempsBtn3;
		/// <summary>
		/// Indique le texte du bouton de temps 1
		/// </summary>
		public static string textBtn1;
		/// <summary>
		/// Indique le texte du bouton de temps 2
		/// </summary>
		public static string textBtn2;
		/// <summary>
		/// Indique le texte du bouton de temps 3
		/// </summary>
		public static string textBtn3;
		/// <summary>
		/// Indique s'il faut fermer l'ordinateur à la fin du décompte
		/// </summary>
		public static bool fermer = false;
		/// <summary>
		/// Instance du compteur pour la fermeture
		/// </summary>
		private Timer timerFermeture;
		/// <summary>
		/// Liste des paramètres configurables depuis le fichiers XML
		/// </summary>
		public DesParametres listeParametres;
		
		/// <summary>
		/// Constructeur du formulaire principal
		/// </summary>
		/// <param name="Args"></param>
		public frmFermeture(string[] Args)
		{
			InitializeComponent();
			// Chargement des paramètres
			bool valeurDefaut = ParametresParDefauts();
			bool configOK = ChargerParametres(Args);
			if(valeurDefaut || configOK) // Si le chargement de la configuration s'est bien passé...
			{
				fermer = true;
				// Si le poste est verrouillé && on ne force pas la fermeture
				if(ControleurEtats.EtatOrdinateur() == UnEtatOrdinateur.verrouille && listeParametres.ForcerFermetureSiVerrouille == false)
				{
					//on ne ferme pas l'ordinateur
					fermer = false;
				}
			}
			else // Sinon, on ne ferme pas l'ordinateur
			{
				fermer = false;
			}
			// Titre de la fenêtre (Ajouter pour avoir une barre de titre visible)
			// Text = listeParametres.titre;
			// Message de description
			lblDesc.Text = listeParametres.description;
			// Logo
			ChargerLogo(listeParametres.logo);
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
			lblBoutonsDesc.Text = listeParametres.texteBoutons;
			// Description du bouton <annuler la fermeture>
			lblAnnulerDesc.Text = listeParametres.texteAnnuler;
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
				listeParametres = new DesParametres();
				listeParametres.titre = "Fermeture des ordinateurs pédagogiques";
				listeParametres.description = "Pour économiser de l'énergie, cet ordinateur va être arrêté pour la nuit. Pour éviter tout désagrément, nous vous recommandons fortement de sauvegarder votre travail en cours. Merci de votre collaboration.";
				listeParametres.delaiMaximum = 99999;
				listeParametres.delaiMinimum = 60;
				listeParametres.delaiAvertissement = 30;
				listeParametres.obligatoire = true;
				listeParametres.fichierXML = "Config.xml";
				listeParametres.id = "0001";
				listeParametres.auDessus = true;
				listeParametres.valeurBouton1 = "10";
				listeParametres.texteBouton1 = "10 secondes";
				listeParametres.valeurBouton2 = "20";
				listeParametres.texteBouton2 = "20 secondes";
				listeParametres.valeurBouton3 = "30";
				listeParametres.texteBouton3 = "30 secondes";
				listeParametres.texteBoutons = "Pour continuer d'utiliser l'ordinateur";
				listeParametres.texteAnnuler = "Pour annuler la fermeture automatique";
				listeParametres.logo = "Logo.png";
				listeParametres.ForcerFermetureSiVerrouille = false;
			}
			catch(Exception e)
			{
				Exception erreur = e;
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
							if(param["AuDessusDeTout"].InnerText != null) { listeParametres.auDessus = Convert.ToBoolean(param["AuDessusDeTout"].InnerText); }
							if(param["Logo"].InnerText != null && File.Exists(param["Logo"].InnerText)) { listeParametres.logo = param["Logo"].InnerText; }
							if(param["ForcerFermetureSiVerrouille"].InnerText != null) { listeParametres.ForcerFermetureSiVerrouille = Convert.ToBoolean(param["ForcerFermetureSiVerrouille"].InnerText); }
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
				Exception erreur = e;
				return false;
			}
			if(listeParametres.titre == "") { return false; }
			return true;
		}
		/// <summary>
		/// Essaie de charger une image
		/// </summary>
		/// <param name="nomFichier"></param>
		private void ChargerLogo(string nomFichier)
		{
		    try
		    {
		        Bitmap unLogo = (Bitmap) Image.FromFile(nomFichier, true);
		        this.pbLogo.BackgroundImage = unLogo;
		        this.pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
		    }
		    catch(System.IO.FileNotFoundException)
		    {
		        //MessageBox.Show("There was an error opening the bitmap." + "Please check the path.");
		    }
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
		void FrmFermetureLoad(object sender, EventArgs e)
		{
	
		}	
	}
}
