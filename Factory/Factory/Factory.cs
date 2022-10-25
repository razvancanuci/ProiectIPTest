/**************************************************************************
 *                                                                        *
 *  File:        Factory.cs                                               *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Acest fișier este responsabil cu generarea întrebarilor  * 
 *               și trimiterea lor către aplicație folosind șablonul      *
 *               creațional Factory.                                      *                          
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

namespace Factory
{
    /// <summary>
    /// Clasa care aplica modelul de proiectare fabrica
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// Metoda care construieste intrebarea selectata pentru mai multe tipuri selectate de pe UI(comentarii mai jos)
        /// </summary>
        /// <param name="tip">Tipul intrebarii</param>
        /// <returns>Un obiect de tipul intrebarii trimise ca parametru</returns>
        public static Intrebare GetQuestion(string tip)
        {
            
            int num;
            switch(tip)
            {
                case "ISTORIE":
                    Thread.Sleep(50);
                    num = new Random().Next(ListeIntrebari.IntrebariIstorie.enunturi.Count);                  
                    return new IntrebareIstorie(ListeIntrebari.IntrebariIstorie.enunturi[num],ListeIntrebari.IntrebariIstorie.variante[num],ListeIntrebari.IntrebariIstorie.varianteCorecte[num]);
                case "FIZICA":
                    Thread.Sleep(50);
                    num = new Random().Next(ListeIntrebari.IntrebariFizica.enunturi.Count);                   
                    return new IntrebareFizica(ListeIntrebari.IntrebariFizica.enunturi[num],ListeIntrebari.IntrebariFizica.variante[num],ListeIntrebari.IntrebariFizica.varianteCorecte[num]);
                case "GEOGRAFIE":
                    Thread.Sleep(50);
                    num = new Random().Next(ListeIntrebari.IntrebariGeografie.enunturi.Count);
                    return new IntrebareGeografie(ListeIntrebari.IntrebariGeografie.enunturi[num],ListeIntrebari.IntrebariGeografie.variante[num],ListeIntrebari.IntrebariGeografie.varianteCorecte[num]);
                case "BIOLOGIE":
                    Thread.Sleep(50);
                    num = new Random().Next(ListeIntrebari.IntrebariBiologie.enunturi.Count);
                    return new IntrebareBiologie(ListeIntrebari.IntrebariBiologie.enunturi[num],ListeIntrebari.IntrebariBiologie.variante[num],ListeIntrebari.IntrebariBiologie.varianteCorecte[num]);
                default:
                    return null;
            }
        }
        /// <summary>
        /// Metoda care genereaza toate cele 20 de intrebari in functie de cate tipuri au fost selectate de UI, daca este mai mult de un tip selectat
        /// </summary>
        /// <param name="types">Tipurile selectate din UI</param>
        /// <returns>O lista cu toate intrebarile generate aleator</returns>
        public static List<Intrebare> GenerateQuestions(List<string> types)
        {
            List<Intrebare> list = new List<Intrebare>();
            switch(types.Count)
            {
                case 1:
                    for(int i=0;i<20;i++)
                    {
                        list.Add(GetQuestionForOneType(types[0],i));
                    }
                    break;
                case 2:
                    for (int i = 0; i < 10; i++)
                    {
                        list.Add(GetQuestion(types[0]));
                        list.Add(GetQuestion(types[1]));
                    }
                    break;
                case 3:
                    for (int i = 0; i < 6; i++)
                    {
                        list.Add(GetQuestion(types[0]));
                        list.Add(GetQuestion(types[1]));
                        list.Add(GetQuestion(types[2]));
                    }
                    list.Add(GetQuestion(types[0]));
                    list.Add(GetQuestion(types[1]));
                    break;
                default:
                    for (int i = 0; i < 5; i++)
                    {
                        list.Add(GetQuestion(types[0]));
                        list.Add(GetQuestion(types[1]));
                        list.Add(GetQuestion(types[2]));
                        list.Add(GetQuestion(types[3]));
                    }
                    break;
            }
            return list;

        }
        /// <summary>
        /// Metoda care este folosita pentru generarea intrebarilor daca este doar un tip selectat pe UI
        /// </summary>
        /// <param name="tip">Tipul selectat de pe UI</param>
        /// <param name="nr">Numarul de ordine al intrebarii(maximul este 20)</param>
        /// <returns>Intrebarea in functie de tipul selectat</returns>
        public static Intrebare GetQuestionForOneType(string tip,int nr)
        {

            switch (tip)
            {
                case "ISTORIE":
                    return new IntrebareIstorie(ListeIntrebari.IntrebariIstorie.enunturi[nr], ListeIntrebari.IntrebariIstorie.variante[nr], ListeIntrebari.IntrebariIstorie.varianteCorecte[nr]);
                case "FIZICA":
                    return new IntrebareFizica(ListeIntrebari.IntrebariFizica.enunturi[nr], ListeIntrebari.IntrebariFizica.variante[nr], ListeIntrebari.IntrebariFizica.varianteCorecte[nr]);
                case "GEOGRAFIE": 
                    return new IntrebareGeografie(ListeIntrebari.IntrebariGeografie.enunturi[nr], ListeIntrebari.IntrebariGeografie.variante[nr], ListeIntrebari.IntrebariGeografie.varianteCorecte[nr]);
                case "BIOLOGIE":
                    return new IntrebareBiologie(ListeIntrebari.IntrebariBiologie.enunturi[nr], ListeIntrebari.IntrebariBiologie.variante[nr], ListeIntrebari.IntrebariBiologie.varianteCorecte[nr]);
                default:
                    return null;
            }
        }

    }
}