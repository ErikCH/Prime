// By: Erik Hanchett
// Date:3/21/2011
// Assignment: #4
// Exercise 28.17

//This class handles the GUI and interacts with the business class. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prime
{
    public partial class PrimeMain : Form
    {
        //fields
        Business biz;
        private static string  ERROR_MSG = " Please enter a whole positive number!";
        private static string TOO_LARGE = " Please enter a smaller number!";
        
        //constructor
        public PrimeMain()
        {
            InitializeComponent();
        }

        //submission click
        private void submitBtn_Click(object sender, EventArgs e)
        {

            //try catch block
            try
            {
                biz = new Business(Math.Abs(Convert.ToInt64(primeBox.Text)));
                primeOutputTB.Text = biz.factor();
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + ERROR_MSG);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message + TOO_LARGE);
            }
        }
    }
}
