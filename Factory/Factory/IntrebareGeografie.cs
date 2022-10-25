/**************************************************************************
 *                                                                        *
 *  File:        IntrebareGeografie.cs                                    *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Acest fișier conține metodele și proprietățile specifice *
 *               întrebării cât și implementarea interfeței               *
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

namespace Factory
{
    /// <summary>
    /// Clasa care se ocupa de intrebarile de geografie. Implementeaza interfata Intrebare
    /// </summary>
    public class IntrebareGeografie: Intrebare
    {
        string enunt;
        public string Enunt {get{return enunt;}}
        List<string> variante;
        public List<string> Variante {get{return variante;}}
        int variantaCorecta;
        public int VariantaCorecta { get { return variantaCorecta; } }
        public IntrebareGeografie(string enuntul, List<string> variantele, int corecta)
        {
            this.enunt=enuntul;
            this.variante=variantele;
            this.variantaCorecta=corecta;
        }
         public bool CheckAnswer(string answer)
         {
            return (answer == variante[variantaCorecta]);
         }
    }
}