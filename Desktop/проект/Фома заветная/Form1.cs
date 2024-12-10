using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фома_заветная
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double one = double.Parse(textBox1.Text);
                double two = double.Parse(textBox2.Text);
                double sum = one / two;
                if (two == 0)
                {
                    labelResult.Text = "На 0 делить нельзя.";
                }
                else
                {
                    labelResult.Text = sum.ToString();
                }
            }
            catch (FormatException) 
            {
                labelResult.Text = "Ошибка:Введите числа.";
            }
            catch (Exception ex)
            {
                labelResult.Text = "Ошибка: " + ex.Message;
            }
        }
    }
}
