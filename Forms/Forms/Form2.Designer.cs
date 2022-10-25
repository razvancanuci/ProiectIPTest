/**************************************************************************
 *                                                                        *
 *  File:        Form2.Designer.cs                                        *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Acest fișier conține toate controalele pentru interfata  *
 *               intermediara cu intrebari                                *
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
    partial class Intermediar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intermediar));
            this.label1 = new System.Windows.Forms.Label();
            this.PrimulRaspuns = new System.Windows.Forms.RadioButton();
            this.Raspuns2 = new System.Windows.Forms.RadioButton();
            this.Raspuns3 = new System.Windows.Forms.RadioButton();
            this.Raspuns4 = new System.Windows.Forms.RadioButton();
            this.NextQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Geografie = new System.Windows.Forms.PictureBox();
            this.Geo = new System.Windows.Forms.PictureBox();
            this.Chimie = new System.Windows.Forms.PictureBox();
            this.History = new System.Windows.Forms.PictureBox();
            this.Multe = new System.Windows.Forms.PictureBox();
            this.Istorie = new System.Windows.Forms.PictureBox();
            this.Fizica = new System.Windows.Forms.PictureBox();
            this.Chemistry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Geografie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chimie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Istorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fizica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chemistry)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = intrebari[0].Enunt;
            // 
            // PrimulRaspuns
            // 
            this.PrimulRaspuns.AutoSize = true;
            this.PrimulRaspuns.Location = new System.Drawing.Point(74, 171);
            this.PrimulRaspuns.Name = "PrimulRaspuns";
            this.PrimulRaspuns.Size = new System.Drawing.Size(17, 16);
            this.PrimulRaspuns.TabIndex = 1;
            this.PrimulRaspuns.Text = intrebari[0].Variante[0];
            this.PrimulRaspuns.TabStop = true;
            this.PrimulRaspuns.UseVisualStyleBackColor = true;
            // 
            // Raspuns2
            // 
            this.Raspuns2.AutoSize = true;
            this.Raspuns2.Location = new System.Drawing.Point(74, 212);
            this.Raspuns2.Name = "Raspuns2";
            this.Raspuns2.Size = new System.Drawing.Size(17, 16);
            this.Raspuns2.TabIndex = 2;
            this.Raspuns2.Text = intrebari[0].Variante[1];
            this.Raspuns2.TabStop = true;
            this.Raspuns2.UseVisualStyleBackColor = true;
            // 
            // Raspuns3
            // 
            this.Raspuns3.AutoSize = true;
            this.Raspuns3.Location = new System.Drawing.Point(74, 249);
            this.Raspuns3.Name = "Raspuns3";
            this.Raspuns3.Size = new System.Drawing.Size(17, 16);
            this.Raspuns3.TabIndex = 3;
            this.Raspuns3.Text = intrebari[0].Variante[2];
            this.Raspuns3.TabStop = true;
            this.Raspuns3.UseVisualStyleBackColor = true;
            // 
            // Raspuns4
            // 
            this.Raspuns4.AutoSize = true;
            this.Raspuns4.Location = new System.Drawing.Point(74, 289);
            this.Raspuns4.Name = "Raspuns4";
            this.Raspuns4.Size = new System.Drawing.Size(17, 16);
            this.Raspuns4.TabIndex = 4;
            this.Raspuns4.Text = intrebari[0].Variante[3];
            this.Raspuns4.TabStop = true;
            this.Raspuns4.UseVisualStyleBackColor = true;
            // 
            // NextQ
            // 
            this.NextQ.Location = new System.Drawing.Point(184, 367);
            this.NextQ.Name = "NextQ";
            this.NextQ.Size = new System.Drawing.Size(152, 23);
            this.NextQ.TabIndex = 5;
            this.NextQ.Text = "Next question";
            this.NextQ.UseVisualStyleBackColor = true;
            this.NextQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Punctaj: " + punctaj + "/" + (20 - intrebari.Count);
            // 
            // Geografie
            // 
            this.Geografie.Image = ((System.Drawing.Image)(resources.GetObject("Geografie.Image")));
            this.Geografie.Location = new System.Drawing.Point(165, 2);
            this.Geografie.Name = "Geografie";
            this.Geografie.Size = new System.Drawing.Size(171, 124);
            this.Geografie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Geografie.TabIndex = 9;
            this.Geografie.TabStop = false;
            // 
            // Geo
            // 
            this.Geo.Image = ((System.Drawing.Image)(resources.GetObject("Geo.Image")));
            this.Geo.Location = new System.Drawing.Point(673, 335);
            this.Geo.Name = "Geo";
            this.Geo.Size = new System.Drawing.Size(164, 114);
            this.Geo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Geo.TabIndex = 10;
            this.Geo.TabStop = false;
            // 
            // Chimie
            // 
            this.Chimie.Image = ((System.Drawing.Image)(resources.GetObject("Chimie.Image")));
            this.Chimie.Location = new System.Drawing.Point(2, 2);
            this.Chimie.Name = "Chimie";
            this.Chimie.Size = new System.Drawing.Size(171, 124);
            this.Chimie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chimie.TabIndex = 11;
            this.Chimie.TabStop = false;
            // 
            // History
            // 
            this.History.Image = ((System.Drawing.Image)(resources.GetObject("History.Image")));
            this.History.Location = new System.Drawing.Point(342, 335);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(169, 114);
            this.History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.History.TabIndex = 12;
            this.History.TabStop = false;
            // 
            // Multe
            // 
            this.Multe.Image = ((System.Drawing.Image)(resources.GetObject("Multe.Image")));
            this.Multe.Location = new System.Drawing.Point(666, 2);
            this.Multe.Name = "Multe";
            this.Multe.Size = new System.Drawing.Size(171, 123);
            this.Multe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Multe.TabIndex = 13;
            this.Multe.TabStop = false;
            // 
            // Istorie
            // 
            this.Istorie.Image = ((System.Drawing.Image)(resources.GetObject("Istorie.Image")));
            this.Istorie.Location = new System.Drawing.Point(498, 2);
            this.Istorie.Name = "Istorie";
            this.Istorie.Size = new System.Drawing.Size(171, 124);
            this.Istorie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Istorie.TabIndex = 14;
            this.Istorie.TabStop = false;
            // 
            // Fizica
            // 
            this.Fizica.Image = ((System.Drawing.Image)(resources.GetObject("Fizica.Image")));
            this.Fizica.Location = new System.Drawing.Point(330, 2);
            this.Fizica.Name = "Fizica";
            this.Fizica.Size = new System.Drawing.Size(171, 123);
            this.Fizica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fizica.TabIndex = 15;
            this.Fizica.TabStop = false;
            // 
            // Chemistry
            // 
            this.Chemistry.Image = ((System.Drawing.Image)(resources.GetObject("Chemistry.Image")));
            this.Chemistry.Location = new System.Drawing.Point(508, 335);
            this.Chemistry.Name = "Chemistry";
            this.Chemistry.Size = new System.Drawing.Size(171, 114);
            this.Chemistry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chemistry.TabIndex = 16;
            this.Chemistry.TabStop = false;
            // 
            // Intermediar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.Chemistry);
            this.Controls.Add(this.Fizica);
            this.Controls.Add(this.Istorie);
            this.Controls.Add(this.Multe);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Chimie);
            this.Controls.Add(this.Geo);
            this.Controls.Add(this.Geografie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextQ);
            this.Controls.Add(this.Raspuns4);
            this.Controls.Add(this.Raspuns3);
            this.Controls.Add(this.Raspuns2);
            this.Controls.Add(this.PrimulRaspuns);
            this.Controls.Add(this.label1);
            this.Name = "Intermediar";
            this.Text = "Test de cultura generala";
            ((System.ComponentModel.ISupportInitialize)(this.Geografie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chimie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Istorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fizica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chemistry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PrimulRaspuns;
        private System.Windows.Forms.RadioButton Raspuns2;
        private System.Windows.Forms.RadioButton Raspuns3;
        private System.Windows.Forms.RadioButton Raspuns4;
        private System.Windows.Forms.Button NextQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Geografie;
        private System.Windows.Forms.PictureBox Geo;
        private System.Windows.Forms.PictureBox Chimie;
        private System.Windows.Forms.PictureBox History;
        private System.Windows.Forms.PictureBox Multe;
        private System.Windows.Forms.PictureBox Istorie;
        private System.Windows.Forms.PictureBox Fizica;
        private System.Windows.Forms.PictureBox Chemistry;
    }
}