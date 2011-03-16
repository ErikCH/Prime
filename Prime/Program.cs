// By: Erik Hanchett
// Date:3/21/2011
// Assignment: #4
// Exercise 28.17

//This class handles the entry point. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prime
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrimeMain());
        }
    }
}
