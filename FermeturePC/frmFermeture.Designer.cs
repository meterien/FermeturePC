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
			this.pnlForm = new System.Windows.Forms.Panel();
			this.lblAnnulerDesc = new System.Windows.Forms.Label();
			this.lblBoutonsDesc = new System.Windows.Forms.Label();
			this.lblTitreDesc = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
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
			this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
			this.pnlForm.Controls.Add(this.btnAjouter10);
			this.pnlForm.Controls.Add(this.btnAjouter20);
			this.pnlForm.Controls.Add(this.pbLogo);
			this.pnlForm.Controls.Add(this.btnAjouter30);
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
			this.Load += new System.EventHandler(this.FrmFermetureLoad);
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
		private System.Windows.Forms.Button btnAjouter10;
		private System.Windows.Forms.Button btnAjouter30;
		private System.Windows.Forms.Button btnAjouter20;
		private System.Windows.Forms.PictureBox pbLogo;
	}
}
