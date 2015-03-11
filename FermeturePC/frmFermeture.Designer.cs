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
			this.btnAjouter30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter30.Location = new System.Drawing.Point(270, 25);
			this.btnAjouter30.Name = "btnAjouter30";
			this.btnAjouter30.Size = new System.Drawing.Size(125, 23);
			this.btnAjouter30.TabIndex = 3;
			this.btnAjouter30.Text = "30 secondes";
			this.btnAjouter30.UseVisualStyleBackColor = true;
			this.btnAjouter30.Click += new System.EventHandler(this.BtnAjouter30Click);
			// 
			// btnAjouter20
			// 
			this.btnAjouter20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter20.Location = new System.Drawing.Point(137, 25);
			this.btnAjouter20.Name = "btnAjouter20";
			this.btnAjouter20.Size = new System.Drawing.Size(125, 23);
			this.btnAjouter20.TabIndex = 2;
			this.btnAjouter20.Text = "20 secondes";
			this.btnAjouter20.UseVisualStyleBackColor = true;
			this.btnAjouter20.Click += new System.EventHandler(this.BtnAjouter20Click);
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnnuler.Location = new System.Drawing.Point(6, 23);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(389, 23);
			this.btnAnnuler.TabIndex = 5;
			this.btnAnnuler.Text = "Annuler la fermeture";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnulerClick);
			// 
			// lblTempsRestant
			// 
			this.lblTempsRestant.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTempsRestant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTempsRestant.ForeColor = System.Drawing.Color.Red;
			this.lblTempsRestant.Location = new System.Drawing.Point(6, 96);
			this.lblTempsRestant.Name = "lblTempsRestant";
			this.lblTempsRestant.Size = new System.Drawing.Size(389, 61);
			this.lblTempsRestant.TabIndex = 6;
			this.lblTempsRestant.Text = "00:00:00";
			this.lblTempsRestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAjouter10
			// 
			this.btnAjouter10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter10.Location = new System.Drawing.Point(6, 25);
			this.btnAjouter10.Name = "btnAjouter10";
			this.btnAjouter10.Size = new System.Drawing.Size(125, 23);
			this.btnAjouter10.TabIndex = 0;
			this.btnAjouter10.Text = "10 secondes";
			this.btnAjouter10.UseVisualStyleBackColor = true;
			this.btnAjouter10.Click += new System.EventHandler(this.BtnAjouter10Click);
			// 
			// pbLogo
			// 
			this.pbLogo.Location = new System.Drawing.Point(301, 20);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(94, 73);
			this.pbLogo.TabIndex = 10;
			this.pbLogo.TabStop = false;
			// 
			// lblDesc
			// 
			this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesc.Location = new System.Drawing.Point(6, 20);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(289, 76);
			this.lblDesc.TabIndex = 12;
			this.lblDesc.Text = "Pour économiser de l\'énergie, cet ordinateur va être arrêté pour la nuit. Pour év" +
	"iter tout désagrément, nous vous recommandons fortement de sauvegarder votre tra" +
	"vail en cours.";
			this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbAjouterTemps
			// 
			this.gbAjouterTemps.AutoSize = true;
			this.gbAjouterTemps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.gbAjouterTemps.BackColor = System.Drawing.Color.DodgerBlue;
			this.gbAjouterTemps.Controls.Add(this.btnAjouter10);
			this.gbAjouterTemps.Controls.Add(this.btnAjouter30);
			this.gbAjouterTemps.Controls.Add(this.btnAjouter20);
			this.gbAjouterTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAjouterTemps.Location = new System.Drawing.Point(3, 163);
			this.gbAjouterTemps.MaximumSize = new System.Drawing.Size(0, 55);
			this.gbAjouterTemps.Name = "gbAjouterTemps";
			this.gbAjouterTemps.Size = new System.Drawing.Size(401, 55);
			this.gbAjouterTemps.TabIndex = 14;
			this.gbAjouterTemps.TabStop = false;
			this.gbAjouterTemps.Text = "Pour continuer d\'utiliser l\'ordinateur";
			// 
			// gbAnnuler
			// 
			this.gbAnnuler.AutoSize = true;
			this.gbAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.gbAnnuler.BackColor = System.Drawing.Color.DodgerBlue;
			this.gbAnnuler.Controls.Add(this.btnAnnuler);
			this.gbAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAnnuler.Location = new System.Drawing.Point(3, 217);
			this.gbAnnuler.MaximumSize = new System.Drawing.Size(0, 55);
			this.gbAnnuler.MinimumSize = new System.Drawing.Size(401, 0);
			this.gbAnnuler.Name = "gbAnnuler";
			this.gbAnnuler.Size = new System.Drawing.Size(401, 55);
			this.gbAnnuler.TabIndex = 15;
			this.gbAnnuler.TabStop = false;
			this.gbAnnuler.Text = "Pour annuler la fermeture automatique";
			// 
			// gbFermeture
			// 
			this.gbFermeture.BackColor = System.Drawing.Color.DodgerBlue;
			this.gbFermeture.Controls.Add(this.lblDesc);
			this.gbFermeture.Controls.Add(this.lblTempsRestant);
			this.gbFermeture.Controls.Add(this.pbLogo);
			this.gbFermeture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFermeture.Location = new System.Drawing.Point(3, 3);
			this.gbFermeture.Name = "gbFermeture";
			this.gbFermeture.Size = new System.Drawing.Size(496, 160);
			this.gbFermeture.TabIndex = 16;
			this.gbFermeture.TabStop = false;
			this.gbFermeture.Text = "Fermeture automatique des ordinateurs";
			// 
			// pnlForm
			// 
			this.pnlForm.Controls.Add(this.gbFermeture);
			this.pnlForm.Controls.Add(this.gbAjouterTemps);
			this.pnlForm.Controls.Add(this.gbAnnuler);
			this.pnlForm.Location = new System.Drawing.Point(12, 12);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Size = new System.Drawing.Size(502, 321);
			this.pnlForm.TabIndex = 17;
			this.pnlForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormPaint);
			// 
			// frmFermeture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 345);
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
			this.gbAjouterTemps.ResumeLayout(false);
			this.gbAnnuler.ResumeLayout(false);
			this.gbFermeture.ResumeLayout(false);
			this.pnlForm.ResumeLayout(false);
			this.pnlForm.PerformLayout();
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
