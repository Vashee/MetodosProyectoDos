using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFilas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(lambda.Text.Any(Char.IsNumber) && miu.Text.Any(Char.IsNumber) &&
                double.Parse(lambda.Text)>=0 && double.Parse(miu.Text)>=0)
            {
                dataGridView1.Visible = true;
                dataGridView1.Rows.Clear();
                string[] rows = new string[20000];
                string[] leyenda = {"ρ", "Lq", "L", "Wq", "W", "Pn" };
                string[] des = {"Factor de utilización","Clientes esperados en el sistema",
                "Clientes en el sistema","Tiempo esperado de los clientes en la cola","Tiempo esperado de estancia de" +
                "los clientes en el sistema","Probabilidad de que haya n clientes en el sistema"};
                double  LN = double.Parse(lambda.Text);
                double  MN = double.Parse(miu.Text);
                double  Lq = Math.Round((LN * LN) / MN * (MN - LN),4);
                double  L = Math.Round(LN / (MN - LN),4);
                double  Wq = Math.Round(LN / MN*(MN - LN),4);
                double  W = Math.Round(1 / (MN - LN),4);
                double rho = Math.Round((LN / MN),4);
                int n = 10;
                double Pn = Math.Round((1 - rho)*Math.Pow(rho,n),4);
                if (Lq >= 0 && L >= 0 && Wq >= 0 && W >= 0)
                {
                    double[] valores = { rho, Lq, L, Wq, W, Pn * 100 };
                    for (int i = 0; i < leyenda.Length; i++)
                    {

                        rows[0] = leyenda[i];
                        rows[1] = valores[i].ToString();
                        rows[2] = des[i];
                        dataGridView1.Rows.Add(rows);
                    }
                }
                else
                {
                    MessageBox.Show("Los resultados tienen valores negativos, favor de ingresar otros valores");
                }



            }
            else
            {
                MessageBox.Show("Favor de ingresar valores númericos números positivos");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lambda_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
