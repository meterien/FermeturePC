/*
 * Created by SharpDevelop.
 * User: josbaril
 * Date: 2014-08-28
 * Time: 16:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FermeturePC
{
	partial class frmFermeture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFermeture));
			this.btnAjouter3 = new System.Windows.Forms.Button();
			this.btnAjouter2 = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.lblTempsRestant = new System.Windows.Forms.Label();
			this.btnAjouter1 = new System.Windows.Forms.Button();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.lblDesc = new System.Windows.Forms.Label();
			this.pnlForm = new System.Windows.Forms.Panel();
			this.lblAnnulerDesc = new System.Windows.Forms.Label();
			this.lblBoutonsDesc = new System.Windows.Forms.Label();
			this.lblTitreDesc = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.pnlForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAjouter3
			// 
			resources.ApplyResources(this.btnAjouter3, "btnAjouter3");
			this.btnAjouter3.Name = "btnAjouter3";
			this.btnAjouter3.UseVisualStyleBackColor = true;
			this.btnAjouter3.Click += new System.EventHandler(this.BtnAjouter3Click);
			// 
			// btnAjouter2
			// 
			resources.ApplyResources(this.btnAjouter2, "btnAjouter2");
			this.btnAjouter2.Name = "btnAjouter2";
			this.btnAjouter2.UseVisualStyleBackColor = true;
			this.btnAjouter2.Click += new System.EventHandler(this.BtnAjouter2Click);
			// 
			// btnAnnuler
			// 
			resources.ApplyResources(this.btnAnnuler, "btnAnnuler");
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnulerClick);
			// 
			// lblTempsRestant
			// 
			this.lblTempsRestant.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTempsRestant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.lblTempsRestant, "lblTempsRestant");
			this.lblTempsRestant.ForeColor = System.Drawing.Color.Red;
			this.lblTempsRestant.Name = "lblTempsRestant";
			// 
			// btnAjouter1
			// 
			resources.ApplyResources(this.btnAjouter1, "btnAjouter1");
			this.btnAjouter1.Name = "btnAjouter1";
			this.btnAjouter1.UseVisualStyleBackColor = true;
			this.btnAjouter1.Click += new System.EventHandler(this.BtnAjouter1Click);
			// 
			// pbLogo
			// 
			resources.ApplyResources(this.pbLogo, "pbLogo");
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.TabStop = false;
			// 
			// lblDesc
			// 
			resources.ApplyResources(this.lblDesc, "lblDesc");
			this.lblDesc.Name = "lblDesc";
			// 
			// pnlForm
			// 
			this.pnlForm.BackColor = System.Drawing.Color.DodgerBlue;
			this.pnlForm.Controls.Add(this.lblAnnulerDesc);
			this.pnlForm.Controls.Add(this.lblBoutonsDesc);
			this.pnlForm.Controls.Add(this.lblTitreDesc);
			this.pnlForm.Controls.Add(this.btnAnnuler);
			this.pnlForm.Controls.Add(this.btnAjouter1);
			this.pnlForm.Controls.Add(this.btnAjouter2);
			this.pnlForm.Controls.Add(this.pbLogo);
			this.pnlForm.Controls.Add(this.btnAjouter3);
			this.pnlForm.Controls.Add(this.lblDesc);
			this.pnlForm.Controls.Add(this.lblTempsRestant);
			resources.ApplyResources(this.pnlForm, "pnlForm");
			this.pnlForm.Name = "pnlForm";
			// 
			// lblAnnulerDesc
			// 
			resources.ApplyResources(this.lblAnnulerDesc, "lblAnnulerDesc");
			this.lblAnnulerDesc.Name = "lblAnnulerDesc";
			// 
			// lblBoutonsDesc
			// 
			resources.ApplyResources(this.lblBoutonsDesc, "lblBoutonsDesc");
			this.lblBoutonsDesc.Name = "lblBoutonsDesc";
			// 
			// lblTitreDesc
			// 
			resources.ApplyResources(this.lblTitreDesc, "lblTitreDesc");
			this.lblTitreDesc.Name = "lblTitreDesc";
			// 
			// frmFermeture
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ControlBox = false;
			this.Controls.Add(this.pnlForm);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFermeture";
			this.Opacity = 0.98D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.pnlForm.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblAnnulerDesc;
		private System.Windows.Forms.Label lblBoutonsDesc;
		private System.Windows.Forms.Label lblTitreDesc;
		private System.Windows.Forms.Panel pnlForm;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.Label lblTempsRestant;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.Button btnAjouter1;
		private System.Windows.Forms.Button btnAjouter3;
		private System.Windows.Forms.Button btnAjouter2;
		private System.Windows.Forms.PictureBox pbLogo;
	}
}
