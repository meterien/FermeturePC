/*
 * Created by SharpDevelop.
 * User: josbaril
 * Date: 2014-09-04
 * Time: 13:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FermeturePC
{
	/// <summary>
	/// Description of frmAvertissement.
	/// </summary>
	public partial class frmAvertissement : Form
	{
		public frmAvertissement()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		/// <summary>
		/// Ferme la fenetre d'avertissement
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BtnFermerFenetreClick(object sender, EventArgs e)
		{
			//frmFermeture.messageOuvert = false;
			this.Close();
		}
	}
}
