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
                double.Parse(lambda.Text)>=0 && double.Parse(miu.Text)>=0 &&
               clientes.Text.Any(Char.IsNumber) && int.Parse(clientes.Text) >= 0
                && listBox1.SelectedItem != null)
              // &&double.Parse(lambda.Text) >= double.Parse(miu.Text))
            {
                dataGridView1.Rows.Clear();
                string[] rows = new string[20000];
                string[] des = {"Factor de utilización","Clientes esperados en el sistema",
                "Clientes en el sistema","Tiempo esperado de los clientes en la cola","Tiempo esperado de estancia de" +
                "los clientes en el sistema", "Probabilidad de que haya n clientes en el sistema" };
                double  LN = double.Parse(lambda.Text);
                double  MN = double.Parse(miu.Text);
                int Nclientes = int.Parse(clientes.Text);
                double  Lq = Math.Round((LN * LN) / MN * (MN - LN),4);
                double  L = Math.Round(LN / (MN - LN),4);
                double  Wq = Math.Round(LN / MN*(MN - LN),4)*60;
                double  W = Math.Round(1 / (MN - LN),4)*60;
                double rho = Math.Round((LN / MN),4);
                string simbol = listBox1.SelectedItem.ToString();
                
                double PN = 0;
                if (simbol == "=")
                {
                    PN = Math.Round((1 - rho) * Math.Pow(rho, Nclientes), 4);
                }
                if (simbol == ">")
                {
                    for (int i = 0; i <= Nclientes; i++)
                    {
                        PN =PN+ Math.Round((1 - rho) * Math.Pow(rho, i), 4);


                    }
                    PN = 1 - PN;
                }
                if (simbol == "<")
                {
                    for (int i = 0; i <= Nclientes; i++)
                    {
                        PN = PN + Math.Round((1 - rho) * Math.Pow(rho, i), 4);

                    }
                }

                if (Lq >= 0 && L >= 0)
                {
                    dataGridView1.Visible = true;
                    string[] leyenda = { "ρ", "Lq", "L", "Wq", "W", "Pn" + simbol + Nclientes };
                    double[] valores = { rho, Lq, L, Wq, W, PN };
                    String[] unidades = { "", " clientes", " clientes", " minutos", " minutos", "" };
                    for (int i = 0; i < leyenda.Length; i++)
                    {

                        rows[0] = leyenda[i];
                        rows[1] = valores[i].ToString()+unidades[i];
                        rows[2] = des[i];
                        dataGridView1.Rows.Add(rows);
                    }
                }
                else
                {
                    MessageBox.Show("Los resultados tienen valores negativos, favor de ingresar otros valores");
                }



            }
            else if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Favor de escoger uno de los símbolos: >, < o =");
            }
            else
            {
                MessageBox.Show("Favor de ingresar valores númericos y positivos");
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
