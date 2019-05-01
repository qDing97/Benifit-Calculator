using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double life, Salary, Retirement, WorkerComp, SST, Medicare, Total;
            Salary = double.Parse(textBox2.Text);
            WorkerComp = (Salary / 1000 * 7.5);

            double med;
            if (radioButton1.Checked)
            {
                med = 6000;


            }
            else if (radioButton2.Checked)
            {
                med = 7200;

            }
            else
            {
                med = 9000;


            }


            if (radioButton4.Checked)
            {
                life = (2 * Salary / 1000 * 2.5); //exempt

            }
            else
            {
                life = (1.5 * Salary / 1000 * 1.5); //not exempt
            }

            if (checkBox1.Checked)
            {
                Retirement = Salary * .05;
            }
            else
            {
                Retirement = 0;
            }

            double FICA;
            if (Salary <= 87900)
            {

                SST = Salary * .062;
                Medicare = Salary * .0145;
                FICA = SST + Medicare;
               
            }
            else
            {
                SST = Salary * .062;
                Medicare = Salary * .0145;
                FICA = SST + Medicare;

            }
            Total = FICA + med + WorkerComp + life;
            textBox3.Text = Total.ToString("c");

        }
    }
}