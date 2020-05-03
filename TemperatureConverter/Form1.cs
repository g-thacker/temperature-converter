using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleClassLibrary;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double StartValue = 0;
            double.TryParse(inputTextBox.Text, out StartValue);
            TempConversionClass myConv = new TempConversionClass();
            myConv.InputTemp = StartValue;
            if (fToCRadio.Checked)
            {
                myConv.TargetScale = "fToC";
                if (StartValue >= 32 && StartValue <= 212)
                {
                    myConv.PerformConversion();
                    outputLabel.Text = myConv.OutputTemp.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Please enter a Fahrenheit value between 32 and 212.");
                }
            }
            else if (cToFRadio.Checked)
            {
                myConv.TargetScale = "cToF";
                if (StartValue >= 0 && StartValue <= 100 && inputTextBox.Text != "")
                {
                    myConv.PerformConversion();
                    outputLabel.Text = myConv.OutputTemp.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Please enter a Celcius value between 0 and 100.");
                }
            }
            else
            {
                MessageBox.Show("Please select either Fahrenheit to Celcius or Celcius to Fahrenheit.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            outputLabel.Text = "";
            fToCRadio.Checked = false;
            cToFRadio.Checked = false;
            inputTextBox.Focus();
        }
    }
}
