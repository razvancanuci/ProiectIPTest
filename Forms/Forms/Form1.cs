/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Interfata de inceput                                     *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Factory;

namespace Forms
{
    /// <summary>
    /// Form-ul principal, cel care se deschide primul la pornirea aplicatiei
    /// </summary>
    public partial class StartPage : Form
    {
        private List<string> tipuriIntrebari;

        private static StartPage _form = null;
        /// <summary>
        /// Constructorul in care se initializeaza componentele de pe interfata grafica
        /// </summary>
        private StartPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Functia de callback a butonului pentru a incepe testul si pentru a genera intrebari
        /// </summary>
        /// <param name="sender">Obiectul care a trimis comanda</param>
        /// <param name="e">Evenimentul</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.Istorie.Checked && !this.Fizica.Checked && !this.Geografie.Checked && !this.Biologie.Checked)
            {
               
                MessageBox.Show("Trebuie sa alegi macar o optiune");
            }
            else
            {
                tipuriIntrebari = new List<string>();
                if (this.Istorie.Checked)
                {
                    tipuriIntrebari.Add(this.Istorie.Text);
                }
                if (this.Fizica.Checked)
                {
                    tipuriIntrebari.Add(this.Fizica.Text);
                }
                if (this.Geografie.Checked)
                {
                    tipuriIntrebari.Add(this.Geografie.Text);
                }
                if (this.Biologie.Checked)
                {
                    tipuriIntrebari.Add(this.Biologie.Text);
                }
                try
                {
                    Intermediar.Punctaj = 0;
                    Intermediar.Intrebari = Factory.Factory.GenerateQuestions(tipuriIntrebari);
                    this.Hide();
                    new Intermediar().ShowDialog();
                    this.Close();
               }catch(Exception exp)
                {
                    throw new StartException("Ceva nu a functionat cum trebuie: " + exp.Message);
                }
            }
        }
        /// <summary>
        /// Functia de callback a butonului de help
        /// </summary>
        /// <param name="sender">Obiectul care a trimis comanda</param>
        /// <param name="e">Evenimentul</param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\vecli\\Desktop\\Proiect-IP-final\\Forms\\Test_de_cultura_generala.chm");
        }
        /// <summary>
        /// Implementarea modelului de proiectare singleton. Pentru a ne asigura ca este doar o instanta a form-ului
        /// </summary>
        /// <returns>Form-ul respectiv</returns>
        public static StartPage GetInstance()
        {
            if (_form == null)
            {
                _form = new StartPage();
            }
            return _form;
        }

        
    }
}
