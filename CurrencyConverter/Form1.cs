using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void Convert()
        {
            var value1 = double.Parse(this.textBox1.Text);
            double value2;
            if (this.comboBox2.SelectedItem.ToString() == "USD")
            {
                if (this.comboBox1.SelectedItem.ToString() == "IDR")
                {
                    value2 = value1 * 14372;
                    this.label3.Text = "Rp." + Math.Round(value2, 2);
                }
                else if (this.comboBox1.SelectedItem.ToString() == "EUR")
                {
                    value2 = value1 / 1.19;
                    this.label3.Text = "€" + Math.Round(value2, 2);
                }
            }
            else if (this.comboBox2.SelectedItem.ToString() == "IDR")
            {

                if (this.comboBox1.SelectedItem.ToString() == "USD")
                {
                    value2 = value1 / 14372;
                    this.label3.Text = "$" + Math.Round(value2, 2);
                }
                else if (this.comboBox1.SelectedItem.ToString() == "EUR")
                {
                    value2 = value1 / 17172;
                    this.label3.Text = "€" + Math.Round(value2, 2);
                }
            }
            else if (this.comboBox2.SelectedItem.ToString() == "EUR")
            {

                if (this.comboBox1.SelectedItem.ToString() == "USD")
                {
                    value2 = value1 * 1.19;
                    this.label3.Text = "$" + Math.Round(value2, 2);
                }
                else if (this.comboBox1.SelectedItem.ToString() == "IDR")
                {
                    value2 = value1 * 17172;
                    this.label3.Text = "Rp." + Math.Round(value2, 2);
                }
            }

        }

        
    }
}
