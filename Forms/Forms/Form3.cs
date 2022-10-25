/**************************************************************************
 *                                                                        *
 *  File:        Form3.cs                                                 *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Interfata de intermediara                                *
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    /// <summary>
    /// Form-ul final, cel care arata rezultatul la testul grila
    /// </summary>
    public partial class Final : Form
    {
        private static Final _form;
        /// <summary>
        /// Constructorul in care se initializeaza componentele de pe interfata grafica
        /// </summary>
        public Final()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Functia de callback pentru a relua testul
        /// </summary>
        /// <param name="sender">Obiectul care a trimis comanda</param>
        /// <param name="e">Evenimentul</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage.GetInstance().ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Implementarea modelului de proiectare singleton. Pentru a ne asigura ca este doar o instanta a form-ului
        /// </summary>
        /// <returns>Form-ul respectiv</returns>
        public static Final GetInstance()
        {
            if (_form == null)
            {
                _form = new Final();
            }
            return _form;
        }
    }
}
