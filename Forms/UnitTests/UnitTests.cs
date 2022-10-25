/**************************************************************************
 *                                                                        *
 *  File:        Factory.cs                                               *
 *  Copyright:   (c) 2021-2022, Răzvan-Andrei Cănuci                      *
 *  E-mail:      razvan-andrei.canuci@student.tuiasi.ro                   *
 *  Description: Acest fișier conține testele pentru verificarea          *
 *               funcționalițății.                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    /// <summary>
    /// Clasa prin care se va face testarea
    /// </summary>
    public class UnitTest
    {
        /// <summary>
        /// Metoda care realizează testul pentru a vedea existența întrebării de geografie
        /// </summary>
        [TestMethod]
        public void FactoryGetMethodTestGeografie()
        {
            Factory.Intrebare a = Factory.Factory.GetQuestion("GEOGRAFIE");
            Assert.IsNotNull(a);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea existența întrebării de istorie
        /// </summary>
        [TestMethod]
        public void FactoryGetMethodTestIstorie()
        {
            Factory.Intrebare a = Factory.Factory.GetQuestion("ISTORIE");
            Assert.IsNotNull(a);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea existența întrebării de fizică
        /// </summary>
        [TestMethod]
        public void FactoryGetMethodTestFizica()
        {
            Factory.Intrebare a = Factory.Factory.GetQuestion("FIZICA");
            Assert.IsNotNull(a);
        }
        [TestMethod]

        /// <summary>
        /// Metoda care realizează testul pentru a vedea existența întrebării de biologie
        /// </summary>
        public void FactoryGetMethodTestBiologie()
        {
            Factory.Intrebare a = Factory.Factory.GetQuestion("BIOLOGIE");
            Assert.IsNotNull(a);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de istorie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestI()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "ISTORIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de geografie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestG()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "GEOGRAFIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de biologie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestB()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "BIOLOGIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de fizică din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestF()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "FIZICA" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de istorie și geografie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestIG()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "ISTORIE", "GEOGRAFIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de istorie și fizică din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestIF()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "ISTORIE", "FIZICA" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de istorie și biologie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestIB()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "ISTORIE", "BIOLOGIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de fizică și geografie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestGF()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "FIZICA", "GEOGRAFIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de biologie și geografie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestGB()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "BIOLOGIE", "GEOGRAFIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de fizică și biologie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestFB()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "FIZICA", "BIOLOGIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de fizică, biologie și istorie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestFBI()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "FIZICA", "BIOLOGIE", "ISTORIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de fizică, biologie și geografie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestFBG()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "FIZICA", "BIOLOGIE", "GEOGRAFIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de biologie, istorie și geografie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestBIG()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "BIOLOGIE", "ISTORIE", "GEOGRAFIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de fizică, istorie si geografie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestFIG()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "FIZICA", "ISTORIE", "GEOGRAFIE" });
            Assert.AreEqual(20, a.Count);
        }

        /// <summary>
        /// Metoda care realizează testul pentru a vedea dacă numărul de întrebări de fizică, istorie, geografie, biologie din listă este corect
        /// </summary>
        [TestMethod]
        public void FactoryGenerateQuestionsTestFIGB()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "FIZICA", "ISTORIE", "GEOGRAFIE", "BIOLOGIE" });
            Assert.AreEqual(20, a.Count);
        }
        [TestMethod]
        public void FactoryGenerateQuestionsTestIFGB()
        {
            List<Factory.Intrebare> a = Factory.Factory.GenerateQuestions(new List<string>() { "ISTORIE", "FIZICA", "GEOGRAFIE", "BIOLOGIE" });
            Assert.AreEqual(20, a.Count);
        }


    }
}
