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
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblAjouterTemps = new System.Windows.Forms.Label();
			this.btnAjouter30 = new System.Windows.Forms.Button();
			this.btnAjouter20 = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.lblAnnulerFermeture = new System.Windows.Forms.Label();
			this.lblTempsRestant = new System.Windows.Forms.Label();
			this.btnAjouter10 = new System.Windows.Forms.Button();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.pnlForm = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.pnlForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDescription
			// 
			this.lblDescription.BackColor = System.Drawing.Color.White;
			this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(11, 12);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(583, 90);
			this.lblDescription.TabIndex = 0;
			this.lblDescription.Text = resources.GetString("lblDescription.Text");
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAjouterTemps
			// 
			this.lblAjouterTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAjouterTemps.Location = new System.Drawing.Point(441, 102);
			this.lblAjouterTemps.Name = "lblAjouterTemps";
			this.lblAjouterTemps.Size = new System.Drawing.Size(127, 17);
			this.lblAjouterTemps.TabIndex = 1;
			this.lblAjouterTemps.Text = "Ajouter du temps pour retarder l\'arrêt";
			this.lblAjouterTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAjouterTemps.Click += new System.EventHandler(this.LblAjouterTempsClick);
			// 
			// btnAjouter30
			// 
			this.btnAjouter30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter30.Location = new System.Drawing.Point(11, 183);
			this.btnAjouter30.Name = "btnAjouter30";
			this.btnAjouter30.Size = new System.Drawing.Size(147, 23);
			this.btnAjouter30.TabIndex = 3;
			this.btnAjouter30.Text = "Travailler 30 secondes";
			this.btnAjouter30.UseVisualStyleBackColor = true;
			this.btnAjouter30.Click += new System.EventHandler(this.BtnAjouter30Click);
			// 
			// btnAjouter20
			// 
			this.btnAjouter20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter20.Location = new System.Drawing.Point(11, 154);
			this.btnAjouter20.Name = "btnAjouter20";
			this.btnAjouter20.Size = new System.Drawing.Size(147, 23);
			this.btnAjouter20.TabIndex = 2;
			this.btnAjouter20.Text = "Travailler 20 secondes";
			this.btnAjouter20.UseVisualStyleBackColor = true;
			this.btnAjouter20.Click += new System.EventHandler(this.BtnAjouter20Click);
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnnuler.Location = new System.Drawing.Point(11, 212);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(147, 35);
			this.btnAnnuler.TabIndex = 5;
			this.btnAnnuler.Text = "Annuler la fermeture";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnulerClick);
			// 
			// lblAnnulerFermeture
			// 
			this.lblAnnulerFermeture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnnulerFermeture.Location = new System.Drawing.Point(11, 102);
			this.lblAnnulerFermeture.Name = "lblAnnulerFermeture";
			this.lblAnnulerFermeture.Size = new System.Drawing.Size(259, 16);
			this.lblAnnulerFermeture.TabIndex = 4;
			this.lblAnnulerFermeture.Text = "Annuler la fermeture et retourner au bureau";
			this.lblAnnulerFermeture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTempsRestant
			// 
			this.lblTempsRestant.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTempsRestant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTempsRestant.ForeColor = System.Drawing.Color.Red;
			this.lblTempsRestant.Location = new System.Drawing.Point(164, 126);
			this.lblTempsRestant.Name = "lblTempsRestant";
			this.lblTempsRestant.Size = new System.Drawing.Size(296, 124);
			this.lblTempsRestant.TabIndex = 6;
			this.lblTempsRestant.Text = "00:00:00";
			this.lblTempsRestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAjouter10
			// 
			this.btnAjouter10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter10.Location = new System.Drawing.Point(11, 125);
			this.btnAjouter10.Name = "btnAjouter10";
			this.btnAjouter10.Size = new System.Drawing.Size(147, 23);
			this.btnAjouter10.TabIndex = 0;
			this.btnAjouter10.Text = "Travailler 10 secondes";
			this.btnAjouter10.UseVisualStyleBackColor = true;
			this.btnAjouter10.Click += new System.EventHandler(this.BtnAjouter10Click);
			// 
			// pbLogo
			// 
			this.pbLogo.Location = new System.Drawing.Point(466, 125);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(128, 124);
			this.pbLogo.TabIndex = 10;
			this.pbLogo.TabStop = false;
			// 
			// pnlForm
			// 
			this.pnlForm.Controls.Add(this.lblDescription);
			this.pnlForm.Controls.Add(this.btnAnnuler);
			this.pnlForm.Controls.Add(this.lblAjouterTemps);
			this.pnlForm.Controls.Add(this.btnAjouter30);
			this.pnlForm.Controls.Add(this.lblAnnulerFermeture);
			this.pnlForm.Controls.Add(this.btnAjouter20);
			this.pnlForm.Controls.Add(this.lblTempsRestant);
			this.pnlForm.Controls.Add(this.btnAjouter10);
			this.pnlForm.Controls.Add(this.pbLogo);
			this.pnlForm.Location = new System.Drawing.Point(3, 3);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Size = new System.Drawing.Size(606, 256);
			this.pnlForm.TabIndex = 11;
			// 
			// frmFermeture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 262);
			this.ControlBox = false;
			this.Controls.Add(this.pnlForm);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFermeture";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fermeture de l\'ordinateur";
			this.Load += new System.EventHandler(this.FrmFermetureLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.pnlForm.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblTempsRestant;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.Label lblAnnulerFermeture;
		private System.Windows.Forms.Button btnAjouter10;
		private System.Windows.Forms.Button btnAjouter30;
		private System.Windows.Forms.Button btnAjouter20;
		private System.Windows.Forms.Label lblAjouterTemps;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Panel pnlForm;
	}
}
