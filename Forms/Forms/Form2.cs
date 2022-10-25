/**************************************************************************
 *                                                                        *
 *  File:        Form2.cs                                                 *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Interfata de final                                       *
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
using System.Threading;
using System.Windows.Forms;

namespace Forms
{
    /// <summary>
    /// Form-ul care afiseaza intrebarea si variantele sale
    /// </summary>
    public partial class Intermediar : Form
    {
        static int punctaj;

        static List<Factory.Intrebare> intrebari = new List<Factory.Intrebare>();
        public static int Punctaj { get { return punctaj; } set { punctaj = value; } }

        public static List<Factory.Intrebare> Intrebari { get { return intrebari; } set { intrebari = value; } }
        /// <summary>
        /// Constructorul in care se initializeaza componentele de pe interfata grafica
        /// </summary>
        public Intermediar()
        {

            InitializeComponent();
            if (intrebari.Count == 1)
            {
                this.NextQ.Text = "Finalizeaza testul";
            }
        }
        /// <summary>
        /// Functia de callback pentru a trece la urmatoarea intrebare sau pentru a finaliza testul daca este ultima intrebare
        /// </summary>
        /// <param name="sender">Obiectul care a trimis comanda</param>
        /// <param name="e">Evenimentul</param>

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.PrimulRaspuns.Checked && !this.Raspuns2.Checked && !this.Raspuns3.Checked && !this.Raspuns4.Checked)
            {
                MessageBox.Show("Selecteaza un raspuns");
            }
            else
            {
                if (this.PrimulRaspuns.Checked)
                {
                    if (this.PrimulRaspuns.Text.Equals(intrebari[0].Variante[intrebari[0].VariantaCorecta]))
                    {
                        punctaj++;
                    }
                }
                if (this.Raspuns2.Checked)
                {
                    if (this.Raspuns2.Text.Equals(intrebari[0].Variante[intrebari[0].VariantaCorecta]))
                    {
                        punctaj++;
                    }
                }
                if (this.Raspuns3.Checked)
                {
                    if (this.Raspuns3.Text.Equals(intrebari[0].Variante[intrebari[0].VariantaCorecta]))
                    {
                        punctaj++;
                    }
                }
                if (this.Raspuns4.Checked)
                {
                    if (this.Raspuns4.Text.Equals(intrebari[0].Variante[intrebari[0].VariantaCorecta]))
                    {
                        punctaj++;
                    }
                }
                intrebari.RemoveAt(0);
                if (intrebari.Count == 0)
                {
                    this.Hide();
                   Final.GetInstance().ShowDialog();
                    this.Close();
                }
                else
                {
                    Thread.Sleep(100);
                    this.Hide();
                    new Intermediar().ShowDialog();
                    this.Close();
                }

            }
        }
    }
}
