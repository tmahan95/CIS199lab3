using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class gratuityCalcFormLab3 : Form
    {
       private const double SMALL_TIP = .15; //Variable that will be used to calculate the smallest tip
       private const double MEDIUM_TIP = .18; //Variable that will be used to calculate the medium tip
       private const double LARGE_TIP = .2; //Variable that will be used to calculate the largest of the tips.
        
        
        public gratuityCalcFormLab3()
        {
            InitializeComponent();
        }

        private void tipCalcButton_Click(object sender, EventArgs e)
        {
            double priceVar= double.Parse (priceTextBox.Text); // This is used to convert the text within the priceTextBox object into a number it stores that number for later manipulation
            smallTipDisplayLabel.Text = (SMALL_TIP * priceVar).ToString("c"); //Small tip calc

            mediumTipDisplayLabel.Text = (MEDIUM_TIP * priceVar).ToString("c");//Medium tip calc

            largeTipDisplayLabel.Text = (LARGE_TIP * priceVar).ToString("c");//Large tip calc





            
        }
    }
}
