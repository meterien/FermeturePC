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
using System.Runtime.InteropServices;

namespace FermeturePC
{
	/// <summary>
	/// Structure qui définit les différents états de l'ordinateur
	/// </summary>
	public enum UnEtatOrdinateur
	{	
		/// <summary>
		/// enVeille : l'ordinateur est en veille
		/// </summary>
		enVeille,
		/// <summary>
		/// L'ordinateur est verrouillé
		/// </summary>
		verrouille,
		/// <summary>
		/// Un session console est ouverte
		/// </summary>
		uneSessionOuverte,
		/// <summary>
		/// L'ordinateur est fermé
		/// </summary>
		fermer
	}
	/// <summary>
	/// Structure qui définit les connexions utilisateurs
	/// </summary>
	public enum UnEtatUtilisateur
	{
		/// <summary>
		/// Un ou plusieur utilisateurs consoles sont connectés
		/// </summary>
		utilisateursConnectes,
		/// <summary>
		/// Aucun utilisateur n'est connecté
		/// </summary>
		aucunUtilisateur,
		/// <summary>
		/// Un ou plusieur utilisateurs terminals sont connectés
		/// </summary>
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
		/// Vérifier l'état de l'ordinateur
		/// </summary>
		/// <returns></returns>
		public static UnEtatOrdinateur EtatOrdinateur()
		{
			var handle = OpenInputDesktop(0, false, 0);
			if (handle != null)
			{
				return UnEtatOrdinateur.uneSessionOuverte;				
			}
      		return UnEtatOrdinateur.verrouille;
		}
		/// <summary>
		/// Vérifier si un utilisateur est connecté
		/// </summary>
		/// <returns></returns>
		public static UnEtatUtilisateur EtatUtilisateur()
		{
			return UnEtatUtilisateur.utilisateursConnectes;
		}
		/// <summary>
		/// Ferme l'ordinateur
		/// </summary>
		public static void FermerOrdinateur(bool PasUnTest)
		{
			if(PasUnTest)
			{
				ManagementBaseObject mboShutdown = null;
	            var mcWin32 = new ManagementClass("Win32_OperatingSystem");
	            mcWin32.Get();
	            mcWin32.Scope.Options.EnablePrivileges = true; // You can't shutdown without security privileges
	            ManagementBaseObject mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");
	            mboShutdownParams["Flags"] = "1"; // Flag 1 means we want to shut down the system
	            mboShutdownParams["Reserved"] = "0";
	            foreach (ManagementObject manObj in mcWin32.GetInstances())
	            {
	                mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
	            }
			}
		}
		/// <summary>
		/// Opens the desktop that receives user input.
		/// </summary>
		/// <param name="dwFlags"></param>
		/// <param name="fInherit"></param>
		/// <param name="dwDesiredAccess"></param>
		/// <returns></returns>
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr OpenInputDesktop(uint dwFlags, bool fInherit, uint dwDesiredAccess);
	}
}
