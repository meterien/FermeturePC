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
			this.btnAjouter30 = new System.Windows.Forms.Button();
			this.btnAjouter20 = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.lblTempsRestant = new System.Windows.Forms.Label();
			this.btnAjouter10 = new System.Windows.Forms.Button();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.lblDesc = new System.Windows.Forms.Label();
			this.gbAjouterTemps = new System.Windows.Forms.GroupBox();
			this.gbAnnuler = new System.Windows.Forms.GroupBox();
			this.gbFermeture = new System.Windows.Forms.GroupBox();
			this.pnlForm = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.gbAjouterTemps.SuspendLayout();
			this.gbAnnuler.SuspendLayout();
			this.gbFermeture.SuspendLayout();
			this.pnlForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAjouter30
			// 
			resources.ApplyResources(this.btnAjouter30, "btnAjouter30");
			this.btnAjouter30.Name = "btnAjouter30";
			this.btnAjouter30.UseVisualStyleBackColor = true;
			this.btnAjouter30.Click += new System.EventHandler(this.BtnAjouter30Click);
			// 
			// btnAjouter20
			// 
			resources.ApplyResources(this.btnAjouter20, "btnAjouter20");
			this.btnAjouter20.Name = "btnAjouter20";
			this.btnAjouter20.UseVisualStyleBackColor = true;
			this.btnAjouter20.Click += new System.EventHandler(this.BtnAjouter20Click);
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
			// btnAjouter10
			// 
			resources.ApplyResources(this.btnAjouter10, "btnAjouter10");
			this.btnAjouter10.Name = "btnAjouter10";
			this.btnAjouter10.UseVisualStyleBackColor = true;
			this.btnAjouter10.Click += new System.EventHandler(this.BtnAjouter10Click);
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
			// gbAjouterTemps
			// 
			resources.ApplyResources(this.gbAjouterTemps, "gbAjouterTemps");
			this.gbAjouterTemps.BackColor = System.Drawing.Color.DodgerBlue;
			this.gbAjouterTemps.Controls.Add(this.btnAjouter10);
			this.gbAjouterTemps.Controls.Add(this.btnAjouter30);
			this.gbAjouterTemps.Controls.Add(this.btnAjouter20);
			this.gbAjouterTemps.Name = "gbAjouterTemps";
			this.gbAjouterTemps.TabStop = false;
			// 
			// gbAnnuler
			// 
			resources.ApplyResources(this.gbAnnuler, "gbAnnuler");
			this.gbAnnuler.BackColor = System.Drawing.Color.DodgerBlue;
			this.gbAnnuler.Controls.Add(this.btnAnnuler);
			this.gbAnnuler.Name = "gbAnnuler";
			this.gbAnnuler.TabStop = false;
			// 
			// gbFermeture
			// 
			this.gbFermeture.BackColor = System.Drawing.Color.DodgerBlue;
			this.gbFermeture.Controls.Add(this.lblDesc);
			this.gbFermeture.Controls.Add(this.lblTempsRestant);
			this.gbFermeture.Controls.Add(this.pbLogo);
			resources.ApplyResources(this.gbFermeture, "gbFermeture");
			this.gbFermeture.Name = "gbFermeture";
			this.gbFermeture.TabStop = false;
			// 
			// pnlForm
			// 
			this.pnlForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlForm.Controls.Add(this.gbFermeture);
			this.pnlForm.Controls.Add(this.gbAjouterTemps);
			this.pnlForm.Controls.Add(this.gbAnnuler);
			resources.ApplyResources(this.pnlForm, "pnlForm");
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormPaint);
			// 
			// frmFermeture
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ControlBox = false;
			this.Controls.Add(this.pnlForm);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFermeture";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Load += new System.EventHandler(this.FrmFermetureLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.gbAjouterTemps.ResumeLayout(false);
			this.gbAnnuler.ResumeLayout(false);
			this.gbFermeture.ResumeLayout(false);
			this.pnlForm.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Panel pnlForm;
		private System.Windows.Forms.GroupBox gbFermeture;
		private System.Windows.Forms.GroupBox gbAnnuler;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.GroupBox gbAjouterTemps;
		private System.Windows.Forms.Label lblTempsRestant;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.Button btnAjouter10;
		private System.Windows.Forms.Button btnAjouter30;
		private System.Windows.Forms.Button btnAjouter20;
		private System.Windows.Forms.PictureBox pbLogo;
	}
}
