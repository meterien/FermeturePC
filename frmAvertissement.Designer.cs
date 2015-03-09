/*
 * Created by SharpDevelop.
 * User: josbaril
 * Date: 2014-09-04
 * Time: 13:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FermeturePC
{
	partial class frmAvertissement
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnFermerFenetre = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFermerFenetre
			// 
			this.btnFermerFenetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFermerFenetre.Location = new System.Drawing.Point(12, 214);
			this.btnFermerFenetre.Name = "btnFermerFenetre";
			this.btnFermerFenetre.Size = new System.Drawing.Size(260, 36);
			this.btnFermerFenetre.TabIndex = 0;
			this.btnFermerFenetre.Text = "Fermer cette fenêtre";
			this.btnFermerFenetre.UseVisualStyleBackColor = true;
			this.btnFermerFenetre.Click += new System.EventHandler(this.BtnFermerFenetreClick);
			// 
			// frmAvertissement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.ControlBox = false;
			this.Controls.Add(this.btnFermerFenetre);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAvertissement";
			this.Text = "Fermeture de l\'ordinateur";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnFermerFenetre;
	}
}
