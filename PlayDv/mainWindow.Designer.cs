using System;
using System.Windows.Forms;

namespace PlayDv
{
    partial class mainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //objets
        private System.Windows.Forms.Button btnExample;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // mainWindow

            btnExample = new System.Windows.Forms.Button();

            btnExample.Text = "resolutfiée";
            //btnExample.Click += BtnExample_Click;

            this.Controls.Add(btnExample);
            // 
            //

            this.Load += MainWindow_Resize;
            this.Resize += MainWindow_Resize;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.ResumeLayout(false);

        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            btnExample.Text = "resolution modifiée";

            btnExample.Location = new System.Drawing.Point(0, 0); // Position du bouton sur la fenêtre
            btnExample.Size = new System.Drawing.Size(newWidth / 2, newHeight / 2); // Taille du bouton (largeur x hauteur)
        }

        #endregion
    }
}

