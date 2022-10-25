/**************************************************************************
 *                                                                        *
 *  File:        StartException.cs                                        *
 *  Copyright:   (c) 2021-2022, Gelu-Florin Boldureanu                    *
 *  E-mail:      gelu-florin.boldureanu@student.tuiasi.ro                 *
 *  Description: Este o clasa pentru tratarea exceptiei de la inceput     *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    /// <summary>
    /// Clasa care mosteneste clasa Exception si o personalizeaza pentru exceptile care sunt la inceputul programului
    /// </summary>
        class StartException : Exception 
    {
        private string _message;
        /// <summary>
        /// Metoda care realizează override la membrul message
        /// </summary>
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        /// <summary>
        /// Metoda care realizeaza functionalitatea noi exceptii create
        /// </summary>
        public StartException(string message) : base()
        {
            _message = message.ToString();
        }
    }
}
