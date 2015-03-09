/*
 * Created by SharpDevelop.
 * User: josbaril
 * Date: 2014-08-29
 * Time: 10:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Management;
using System.Windows.Forms;

namespace FermeturePC
{
	// Structure qui définit les différents états de l'ordinateur
	public enum UnEtatOrdinateur
	{	
		enVeille,
		verrouille,
		uneSessionOuverte,
		fermer
	}
	// Structure qui définit les connexions utilisateurs
	public enum UnEtatUtilisateur
	{
		utilisateurConnecte,
		aucunUtilisateur,
		utilisateurDistant
	}
	/// <summary>
	/// Description of ControleurEtats.
	/// </summary>
	public class ControleurEtats
	{	
		/// <summary>
		/// Constructeur par défaut
		/// </summary>
		public ControleurEtats()
		{
		}
		/// <summary>
		/// Vérifier l'état de l'ordinateur(veille, ouvert, verrouillé, etc)
		/// </summary>
		/// <returns></returns>
		public static UnEtatOrdinateur EtatOrdinateur()
		{
			return UnEtatOrdinateur.uneSessionOuverte;
		}
		/// <summary>
		/// Vérifier si un utilisateur est connecté
		/// </summary>
		/// <returns></returns>
		public static UnEtatUtilisateur EtatUtilisateur()
		{
			return UnEtatUtilisateur.utilisateurConnecte;
		}
		/// <summary>
		/// Ferme l'ordinateur
		/// </summary>
		public static void FermerOrdinateur(bool PasUnTest)
		{
			if(PasUnTest)
			{
				ManagementBaseObject mboShutdown = null;
	            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
	            mcWin32.Get();
	            // You can't shutdown without security privileges
	            mcWin32.Scope.Options.EnablePrivileges = true;
	            ManagementBaseObject mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");
	            // Flag 1 means we want to shut down the system
	            mboShutdownParams["Flags"] = "1";
	            mboShutdownParams["Reserved"] = "0";
	            foreach (ManagementObject manObj in mcWin32.GetInstances())
	            {
	                mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
	            }
			}
			else
			{
				// MessageBox.Show("Fonction : FermerOrdinateur");
			}
		}
	}
}
