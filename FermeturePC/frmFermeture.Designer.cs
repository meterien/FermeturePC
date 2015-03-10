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
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.lblAnnulerFermeture = new System.Windows.Forms.Label();
			this.btnAjouter30 = new System.Windows.Forms.Button();
			this.btnAjouter20 = new System.Windows.Forms.Button();
			this.lblAjouterTemps = new System.Windows.Forms.Label();
			this.btnAjouter10 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblInfoOrdinateur = new System.Windows.Forms.Label();
			this.lblTempsRestant = new System.Windows.Forms.Label();
			this.pnlForm = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnlForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbLogo
			// 
			this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbLogo.Location = new System.Drawing.Point(3, 3);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(172, 157);
			this.pbLogo.TabIndex = 4;
			this.pbLogo.TabStop = false;
			// 
			// lblDescription
			// 
			this.lblDescription.BackColor = System.Drawing.Color.Transparent;
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(181, 16);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(311, 134);
			this.lblDescription.TabIndex = 0;
			this.lblDescription.Text = resources.GetString("lblDescription.Text");
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAnnuler);
			this.panel2.Controls.Add(this.lblAnnulerFermeture);
			this.panel2.Controls.Add(this.btnAjouter30);
			this.panel2.Controls.Add(this.btnAjouter20);
			this.panel2.Controls.Add(this.lblAjouterTemps);
			this.panel2.Controls.Add(this.btnAjouter10);
			this.panel2.Location = new System.Drawing.Point(5, 166);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(170, 222);
			this.panel2.TabIndex = 7;
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnnuler.Location = new System.Drawing.Point(23, 186);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(127, 23);
			this.btnAnnuler.TabIndex = 5;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnulerClick);
			// 
			// lblAnnulerFermeture
			// 
			this.lblAnnulerFermeture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnnulerFermeture.Location = new System.Drawing.Point(3, 137);
			this.lblAnnulerFermeture.Name = "lblAnnulerFermeture";
			this.lblAnnulerFermeture.Size = new System.Drawing.Size(165, 46);
			this.lblAnnulerFermeture.TabIndex = 4;
			this.lblAnnulerFermeture.Text = "Annuler la fermeture et retourner au bureau";
			this.lblAnnulerFermeture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAjouter30
			// 
			this.btnAjouter30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter30.Location = new System.Drawing.Point(23, 106);
			this.btnAjouter30.Name = "btnAjouter30";
			this.btnAjouter30.Size = new System.Drawing.Size(127, 23);
			this.btnAjouter30.TabIndex = 3;
			this.btnAjouter30.Text = "30 secondes";
			this.btnAjouter30.UseVisualStyleBackColor = true;
			this.btnAjouter30.Click += new System.EventHandler(this.BtnAjouter30Click);
			// 
			// btnAjouter20
			// 
			this.btnAjouter20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter20.Location = new System.Drawing.Point(23, 77);
			this.btnAjouter20.Name = "btnAjouter20";
			this.btnAjouter20.Size = new System.Drawing.Size(127, 23);
			this.btnAjouter20.TabIndex = 2;
			this.btnAjouter20.Text = "20 secondes";
			this.btnAjouter20.UseVisualStyleBackColor = true;
			this.btnAjouter20.Click += new System.EventHandler(this.BtnAjouter20Click);
			// 
			// lblAjouterTemps
			// 
			this.lblAjouterTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAjouterTemps.Location = new System.Drawing.Point(3, 13);
			this.lblAjouterTemps.Name = "lblAjouterTemps";
			this.lblAjouterTemps.Size = new System.Drawing.Size(165, 32);
			this.lblAjouterTemps.TabIndex = 1;
			this.lblAjouterTemps.Text = "Ajouter du temps pour retarder l\'arrêt";
			this.lblAjouterTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAjouter10
			// 
			this.btnAjouter10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter10.Location = new System.Drawing.Point(23, 48);
			this.btnAjouter10.Name = "btnAjouter10";
			this.btnAjouter10.Size = new System.Drawing.Size(127, 23);
			this.btnAjouter10.TabIndex = 0;
			this.btnAjouter10.Text = "10 secondes";
			this.btnAjouter10.UseVisualStyleBackColor = true;
			this.btnAjouter10.Click += new System.EventHandler(this.BtnAjouter10Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.lblInfoOrdinateur);
			this.panel3.Location = new System.Drawing.Point(206, 352);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(259, 36);
			this.panel3.TabIndex = 8;
			this.panel3.Visible = false;
			// 
			// lblInfoOrdinateur
			// 
			this.lblInfoOrdinateur.Enabled = false;
			this.lblInfoOrdinateur.Location = new System.Drawing.Point(3, 78);
			this.lblInfoOrdinateur.Name = "lblInfoOrdinateur";
			this.lblInfoOrdinateur.Size = new System.Drawing.Size(245, 25);
			this.lblInfoOrdinateur.TabIndex = 0;
			// 
			// lblTempsRestant
			// 
			this.lblTempsRestant.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTempsRestant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTempsRestant.ForeColor = System.Drawing.Color.Red;
			this.lblTempsRestant.Location = new System.Drawing.Point(223, 224);
			this.lblTempsRestant.Name = "lblTempsRestant";
			this.lblTempsRestant.Size = new System.Drawing.Size(233, 64);
			this.lblTempsRestant.TabIndex = 6;
			this.lblTempsRestant.Text = "00:00:00";
			this.lblTempsRestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlForm
			// 
			this.pnlForm.Controls.Add(this.pbLogo);
			this.pnlForm.Controls.Add(this.panel3);
			this.pnlForm.Controls.Add(this.panel2);
			this.pnlForm.Controls.Add(this.lblTempsRestant);
			this.pnlForm.Controls.Add(this.lblDescription);
			this.pnlForm.Location = new System.Drawing.Point(12, 12);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Size = new System.Drawing.Size(500, 408);
			this.pnlForm.TabIndex = 9;
			// 
			// frmFermeture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 429);
			this.ControlBox = false;
			this.Controls.Add(this.pnlForm);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFermeture";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fermeture de l\'ordinateur";
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.pnlForm.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Panel pnlForm;
		private System.Windows.Forms.Label lblInfoOrdinateur;
		private System.Windows.Forms.Label lblTempsRestant;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.Label lblAnnulerFermeture;
		private System.Windows.Forms.Button btnAjouter10;
		private System.Windows.Forms.Button btnAjouter30;
		private System.Windows.Forms.Button btnAjouter20;
		private System.Windows.Forms.Label lblAjouterTemps;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pbLogo;
	}
}
