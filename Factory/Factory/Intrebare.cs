/**************************************************************************
 *                                                                        *
 *  File:        Intrebare.cs                                             *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Acest fișier conține interfața Întrebare, aceasta        *
 *               conține proprietăți și metode de bază pentru fiecare tip *
 *               de întrebare.                                            *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 **************************************************************************/



using System.Collections.Generic;

namespace Factory
{
    /// <summary>
    /// Interfata intrebare care are un enunt, variante si varianta corecta
    /// </summary>
    public interface Intrebare
    {
         string Enunt { get; }
         List<string> Variante { get; }

        int VariantaCorecta { get; }
        /// <summary>
        /// Metoda care verifica daca raspunsul selectat de pe UI este corect (egal cu variante corecta)
        /// Metoda este abstracta, ea urmand sa fie implementata de celelalte clase
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        bool CheckAnswer(string answer);
    }
}
