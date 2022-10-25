/**************************************************************************
 *                                                                        *
 *  File:        ListeIntrebari.cs                                        *
 *  Copyright:   (c) 2021-2022, Draia-Teodora Vecliuc                     *
 *  E-mail:      draia-teodora.vecliuc@student.tuiasi.ro                  *
 *  Description: Acest fișier conține clasele ce au listele cu            *
 *               întrebările specifice pentru fiecare domeniu cât și clasa*
 *               responsabilă cu căutarea informațiilor în aceste liste,  *
 *               extragerea informațiilor din fișiere și verificarea      *
 *               răspunsului pentru întrebare.                            *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;

namespace ListeIntrebari
{
    /// <summary>
    /// Clasa prin care se va face extragerea intrebarilor din fisiere
    /// </summary>
    public class CautInfo
    {
        public const string path = "C:\\Users\\vecli\\Desktop\\Proiect-IP-final\\Intrebari\\";
        /// <summary>
        /// Metoda care extrage din fisier enunturile la intrebari
        /// </summary>
        /// <param name="filename">Numele fisierului unde se gasesc enunturile</param>
        /// <returns>O lista cu enunturile la intrebari</returns>
        public static List<string> Enunturi(string filename)
        {
            List<string> mylist = new List<string>();
            foreach (string line in System.IO.File.ReadLines(path + filename))
            {

                mylist.Add(line.Trim());
                Console.WriteLine(line);
            }
            return mylist;
        }
        /// <summary>
        /// Metoda care extrage variantele de raspusn la fiecare enunt in parte
        /// </summary>
        /// <param name="filename">Numele fisierului unde se gasesc variantele</param>
        /// <returns>O lista ce contine mai multe liste cu fiecare varianta in parte</returns>
        public static List<List<string>> Variante(string filename)
        {
            List<List<string>> mylist = new List<List<string>>();
            foreach (string line in System.IO.File.ReadLines(path + filename))
            {
                List<string> new_elem = new List<string>();
                string[] raspunsuri = line.Split('#');
                foreach (var raspuns in raspunsuri)
                {
                    new_elem.Add(raspuns);
                }
                mylist.Add(new_elem);

            }
            return mylist;
        }
        /// <summary>
        /// Metoda care extrage din fisier numarul de ordine al variantei care este corecta
        /// </summary>
        /// <param name="filename">Numele fisierului unde se gasesc numerele intregi ce semnifica varianta corecta</param>
        /// <returns>O lista cu toate variantele corecte</returns>
        public static List<int> RaspunsCorect(string filename)
        {
            List<int> mylist = new List<int>();
            foreach (string line in System.IO.File.ReadLines(path + filename))
            {

                mylist.Add(Int16.Parse(line.Trim()));

            }
            return mylist;
        }

    }
    /// <summary>
    /// Clasa care contine intrebarile de istorie si care extrage datele din fisierele: istorie.txt, variante_istorie.txt, raspunsuri_istorie.txt
    /// </summary>
    public class IntrebariIstorie
    {
        public static List<string> enunturi = CautInfo.Enunturi("istorie.txt");
        public static List<List<string>> variante = CautInfo.Variante("variante_istorie.txt");
        public static List<int> varianteCorecte = CautInfo.RaspunsCorect("raspunsuri_istorie.txt");
    }
    /// <summary>
    /// Clasa care contine intrebarile de fizica si care extrage datele din fisierele: fizica.txt, variante_fizica.txt, raspunsuri_fizica.txt
    /// </summary>
    public class IntrebariFizica
    {
        public static List<string> enunturi = CautInfo.Enunturi("fizica.txt");
        public static List<List<string>> variante = CautInfo.Variante("variante_fizica.txt");
        public static List<int> varianteCorecte = CautInfo.RaspunsCorect("raspunsuri_fizica.txt");
    }
    /// <summary>
    /// Clasa care contine intrebarile de geografie si care extrage datele din fisierele: geografie.txt, variante_geografie.txt, raspunsuri_geografie.txt
    /// </summary>
    public class IntrebariGeografie
    {
        public static List<string> enunturi = CautInfo.Enunturi("geografie.txt");
        public static List<List<string>> variante = CautInfo.Variante("variante_geografie.txt");
        public static List<int> varianteCorecte = CautInfo.RaspunsCorect("raspunsuri_geografie.txt");
    }
    /// <summary>
    /// Clasa care contine intrebarile de biologie si care extrage datele din fisierele: biologie.txt, variante_biologie.txt, raspunsuri_biologie.txt
    /// </summary>
    public class IntrebariBiologie
    {
        public static List<string> enunturi = CautInfo.Enunturi("biologie.txt");
        public static List<List<string>> variante = CautInfo.Variante("variante_biologie.txt");
        public static List<int> varianteCorecte = CautInfo.RaspunsCorect("raspunsuri_biologie.txt");
    }

}
