/**************************************************************************
 *                                                                        *
 *  File:        Form1.Designer.cs                                        *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Acest fișier conține toate controalele pentru interfata  *
 *               de inceput unde trebuie  selectat o categorie            *
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
    /// <summary>
    /// Form-ul principal, cel care se deschide primul la pornirea aplicatiei
    /// </summary>
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.SmartPants = new System.Windows.Forms.Label();
            this.Istorie = new System.Windows.Forms.CheckBox();
            this.Fizica = new System.Windows.Forms.CheckBox();
            this.Geografie = new System.Windows.Forms.CheckBox();
            this.Biologie = new System.Windows.Forms.CheckBox();
            this.IncepeJocul = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuizNight = new System.Windows.Forms.PictureBox();
            this.Smart = new System.Windows.Forms.PictureBox();
            this.Confused = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuizNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confused)).BeginInit();
            this.SuspendLayout();
            // 
            // SmartPants
            // 
            this.SmartPants.AutoSize = true;
            this.SmartPants.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.72F);
            this.SmartPants.ForeColor = System.Drawing.Color.HotPink;
            this.SmartPants.ImageKey = "(none)";
            this.SmartPants.Location = new System.Drawing.Point(392, 103);
            this.SmartPants.Name = "SmartPants";
            this.SmartPants.Size = new System.Drawing.Size(330, 61);
            this.SmartPants.TabIndex = 0;
            this.SmartPants.Text = "SmartyPants";
            
            // 
            // Istorie
            // 
            this.Istorie.AutoSize = true;
            this.Istorie.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Istorie.Location = new System.Drawing.Point(247, 287);
            this.Istorie.Name = "Istorie";
            this.Istorie.Size = new System.Drawing.Size(73, 20);
            this.Istorie.TabIndex = 1;
            this.Istorie.Text = "ISTORIE";
            this.Istorie.UseVisualStyleBackColor = true;
            // 
            // Fizica
            // 
            this.Fizica.AutoSize = true;
            this.Fizica.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fizica.Location = new System.Drawing.Point(484, 287);
            this.Fizica.Name = "Fizica";
            this.Fizica.Size = new System.Drawing.Size(69, 20);
            this.Fizica.TabIndex = 2;
            this.Fizica.Text = "FIZICA";
            this.Fizica.UseVisualStyleBackColor = true;
            // 
            // Geografie
            // 
            this.Geografie.AutoSize = true;
            this.Geografie.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geografie.Location = new System.Drawing.Point(247, 330);
            this.Geografie.Name = "Geografie";
            this.Geografie.Size = new System.Drawing.Size(94, 20);
            this.Geografie.TabIndex = 3;
            this.Geografie.Text = "GEOGRAFIE";
            this.Geografie.UseVisualStyleBackColor = true;
            // 
            // Biologie
            // 
            this.Biologie.AutoSize = true;
            this.Biologie.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biologie.Location = new System.Drawing.Point(484, 330);
            this.Biologie.Name = "Biologie";
            this.Biologie.Size = new System.Drawing.Size(83, 20);
            this.Biologie.TabIndex = 4;
            this.Biologie.Text = "BIOLOGIE";
            this.Biologie.UseVisualStyleBackColor = true;
            // 
            // IncepeJocul
            // 
            this.IncepeJocul.BackColor = System.Drawing.Color.White;
            this.IncepeJocul.ForeColor = System.Drawing.Color.DarkKhaki;
            this.IncepeJocul.Location = new System.Drawing.Point(334, 239);
            this.IncepeJocul.Name = "IncepeJocul";
            this.IncepeJocul.Size = new System.Drawing.Size(149, 28);
            this.IncepeJocul.TabIndex = 5;
            this.IncepeJocul.Text = "Incepe testul";
            this.IncepeJocul.UseVisualStyleBackColor = false;
            this.IncepeJocul.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // QuizNight
            // 
            this.QuizNight.Image = ((System.Drawing.Image)(resources.GetObject("QuizNight.Image")));
            this.QuizNight.Location = new System.Drawing.Point(35, 51);
            this.QuizNight.Name = "QuizNight";
            this.QuizNight.Size = new System.Drawing.Size(296, 177);
            this.QuizNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuizNight.TabIndex = 7;
            this.QuizNight.TabStop = false;
            // 
            // Smart
            // 
            this.Smart.Image = ((System.Drawing.Image)(resources.GetObject("Smart.Image")));
            this.Smart.Location = new System.Drawing.Point(35, 275);
            this.Smart.Name = "Smart";
            this.Smart.Size = new System.Drawing.Size(163, 137);
            this.Smart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Smart.TabIndex = 8;
            this.Smart.TabStop = false;
            // 
            // Confused
            // 
            this.Confused.Image = ((System.Drawing.Image)(resources.GetObject("Confused.Image")));
            this.Confused.Location = new System.Drawing.Point(643, 275);
            this.Confused.Name = "Confused";
            this.Confused.Size = new System.Drawing.Size(141, 137);
            this.Confused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Confused.TabIndex = 9;
            this.Confused.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.Confused);
            this.Controls.Add(this.Smart);
            this.Controls.Add(this.QuizNight);
            this.Controls.Add(this.IncepeJocul);
            this.Controls.Add(this.Biologie);
            this.Controls.Add(this.Geografie);
            this.Controls.Add(this.Fizica);
            this.Controls.Add(this.Istorie);
            this.Controls.Add(this.SmartPants);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StartPage";
            this.Text = "Test de cultura generala";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuizNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confused)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SmartPants;
        private System.Windows.Forms.CheckBox Istorie;
        private System.Windows.Forms.CheckBox Fizica;
        private System.Windows.Forms.CheckBox Geografie;
        private System.Windows.Forms.CheckBox Biologie;
        private System.Windows.Forms.Button IncepeJocul;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox QuizNight;
        private System.Windows.Forms.PictureBox Smart;
        private System.Windows.Forms.PictureBox Confused;
    }
}

