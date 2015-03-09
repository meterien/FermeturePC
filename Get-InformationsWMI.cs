/*
 * Created by SharpDevelop.
 * User: josbaril
 * Date: 2014-09-04
 * Time: 08:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Management;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Management.Instrumentation;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FermeturePC
{
	/// <summary>
	/// Structure qui permet de contenir les informations générales d'un ordinateur
	/// </summary>
	public struct ObjInfosOrdinateur
	{
		public string nom;
		public string ip;
		public string DernierDemarrage;
		public string processeur;
		public string memoireRam;
		public string modele;
		public string fabricant;
	}
	/// <summary>
	/// Description of Get_InformationsWMI.
	/// </summary>
	public class Get_InformationsWMI
	{
		public Get_InformationsWMI()
		{
		}
		
		/// <summary>
		/// Retourne le nom de l'ordinateur en cours
		/// </summary>
		/// <param name="nomOrdinateur">Nom de l'ordinateur</param>
		/// <returns></returns>
		public static string GetComputerName(string nomOrdinateur)
		{
			string tmp = "";
			ManagementClass classeWmi = new ManagementClass("Win32_ComputerSystem");
			ManagementObjectCollection objetsWmi = classeWmi.GetInstances();
			foreach(ManagementObject objet in objetsWmi)
			{
				if(objet["Name"] != null)
				{
					tmp = (string)objet["Name"];
				}
			}
			return tmp;
		}
		/// <summary>
		/// Obtient l'addresse IP de l'ordinateur passer en paramètre
		/// </summary>
		/// <param name="computerName">Nom de l'ordinateur que l'on veut récupérer l'addresse IP</param>
		public static List<string> GetAdresseIP(string computerName)
		{
			List<String> listeIP = new List<string>();
			ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
        	ManagementObjectCollection allConfigs = wmi.GetInstances();
			foreach(ManagementBaseObject wmi_inf in allConfigs)
			{
				if(wmi_inf["IPAddress"] != null)
				{
					if (wmi_inf["IPAddress"] is Array)
					{
						string[] addresses = (string[])wmi_inf["IPAddress"];
						listeIP.Add(addresses[0]);
					}
					else
					{
						listeIP.Add(wmi_inf["IPAddress"].ToString());
					}
				}
			}
			return listeIP;
		}
		/// <summary>
		/// Exécute et retourne le résultat d'une requête wmi
		/// </summary>
		/// <param name="requete">String contenant la requête wmi</param>
		/// <param name="nomOrdinateur">Nom de l'ordinateur duquel faire la requête</param>
		/// <returns></returns>
		public static ManagementObjectSearcher requeteWMI(SelectQuery requete, string nomOrdinateur)
		{
			ManagementObjectSearcher recherche = new ManagementObjectSearcher();
			try
			{
				recherche = new ManagementObjectSearcher(requete);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return recherche;
		}
		/// <summary>
		/// Retourne la date et heure du dernier démarrage
		/// </summary>
		/// <param name="nomOrdinateur">Nom de l'ordinateur duquel retourner l'heure du dernier démarrage</param>
		/// <returns></returns>
		public static string GetDernierDemarrage(string nomOrdinateur)
		{
			string tmp = "";
			ManagementClass classeWmi = new ManagementClass("Win32_OperatingSystem");
			ManagementObjectCollection objetsWmi = classeWmi.GetInstances();
			foreach(ManagementObject objet in objetsWmi)
			{
				if(objet["LastBootUpTime"] != null)
				{
					tmp = (string)objet["LastBootUpTime"];
				}
			}
			return tmp;
		}
		/// <summary>
		/// Retourne les informations du fabricant et du modèle de l'ordinateur
		/// </summary>
		/// <param name="nomOrdinateur">Nom de l'ordinateur duquel retourner le modèle</param>
		/// <returns></returns>
		public static ObjInfosOrdinateur GetModele(string nomOrdinateur)
		{
			ObjInfosOrdinateur tmp = new ObjInfosOrdinateur();
			ManagementClass classeWmi = new ManagementClass("Win32_ComputerSystemProduct");
			ManagementObjectCollection objetsWmi = classeWmi.GetInstances();
			foreach(ManagementObject objet in objetsWmi)
			{
				if(objet["Vendor"] != null)
				{
					tmp.fabricant += " " + (string)objet["Vendor"];
				}
				if(objet["Name"] != null)
				{
					tmp.modele += " " + (string)objet["Name"];
				}
			}
			return tmp;
		}
		// CPU - RAM
		// DISQUE - Espace libre
				/// <summary>
		/// Convertie une date CIM en une date normal
		/// </summary>
		/// <param name="dateWMI"></param>
		/// <returns></returns>
		DateTime convertirWmiDate(string dateWMi)
		{
			DateTime tmp = DateTime.MinValue;
			try
			{
		    	if(dateWMi != null && dateWMi.IndexOf('.') != -1)
			    {
			        string nouvelleDate = dateWMi.Substring(0, dateWMi.IndexOf('.') + 4);
			        if(nouvelleDate.Length == 18)
			        {
			            int y = Convert.ToInt32(nouvelleDate.Substring(0, 4));
			            int m = Convert.ToInt32(nouvelleDate.Substring(4, 2));
			            int d = Convert.ToInt32(nouvelleDate.Substring(6, 2));
			            int h = Convert.ToInt32(nouvelleDate.Substring(8, 2));
			            int mm = Convert.ToInt32(nouvelleDate.Substring(10, 2));
			            int s = Convert.ToInt32(nouvelleDate.Substring(12, 2));
			            int ms = Convert.ToInt32(nouvelleDate.Substring(15, 3));
			            tmp = new DateTime(y, m, d, h, mm, s, ms);
			        }
			    }
			}
			catch
			{
				tmp = new DateTime();
			}
	    	return tmp;
		}
	}
}
