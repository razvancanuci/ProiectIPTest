/**************************************************************************
 *                                                                        *
 *  File:        Form1.Designer.cs                                        *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Acest fișier conține toate controalele pentru interfata  *
 *               finala cu puntajul final si obtiunea de a reincepe jocul *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 **************************************************************************/
namespace Forms
{
    partial class Final
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            this.PunctajText = new System.Windows.Forms.Label();
            this.Replay = new System.Windows.Forms.Button();
            this.Puntaj = new System.Windows.Forms.Label();
            this.Felicitari = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Felicitari)).BeginInit();
            this.SuspendLayout();
            // 
            // PunctajText
            // 
            this.PunctajText.AutoSize = true;
            this.PunctajText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunctajText.Location = new System.Drawing.Point(12, 33);
            this.PunctajText.Name = "PunctajText";
            this.PunctajText.Size = new System.Drawing.Size(156, 20);
            this.PunctajText.TabIndex = 1;
            this.PunctajText.Text = "Punctajul obtinut:";
            // 
            // Replay
            // 
            this.Replay.BackColor = System.Drawing.Color.HotPink;
            this.Replay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Replay.BackgroundImage")));
            this.Replay.Location = new System.Drawing.Point(652, 33);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(146, 37);
            this.Replay.TabIndex = 3;
            this.Replay.Text = "Replay";
            this.Replay.UseVisualStyleBackColor = false;
            this.Replay.Click += new System.EventHandler(this.button1_Click);
            // 
            // Puntaj
            // 
            this.Puntaj.AutoSize = true;
            this.Puntaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Puntaj.Location = new System.Drawing.Point(132, 53);
            this.Puntaj.Name = "Puntaj";
            this.Puntaj.Size = new System.Drawing.Size(36, 39);
            this.Puntaj.TabIndex = 4;
            this.Puntaj.Text = "0";
            this.Puntaj.Text = Intermediar.Punctaj + "/20";
            // 
            // Felicitari
            // 
            this.Felicitari.Image = ((System.Drawing.Image)(resources.GetObject("Felicitari.Image")));
            this.Felicitari.Location = new System.Drawing.Point(1, 92);
            this.Felicitari.Name = "Felicitari";
            this.Felicitari.Size = new System.Drawing.Size(797, 367);
            this.Felicitari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Felicitari.TabIndex = 5;
            this.Felicitari.TabStop = false;
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Felicitari);
            this.Controls.Add(this.Puntaj);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.PunctajText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Final";
            this.Text = "Test de cultura generala";
            ((System.ComponentModel.ISupportInitialize)(this.Felicitari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PunctajText;
        private System.Windows.Forms.Button Replay;
        private System.Windows.Forms.Label Puntaj;
        private System.Windows.Forms.PictureBox Felicitari;
    }
}