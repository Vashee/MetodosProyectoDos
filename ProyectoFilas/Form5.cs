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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public double factorial(int n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public double P0(int s, int k, double LN, double MN)
        {
            double P0 = 0;
            double sec1 = 0;
            double sec3 = 0;
            double sec2, ifact, sfact;
            sfact = factorial(s);

            for (int i = 0; i <= s; i++)
            {
                ifact = factorial(i);
                sec1 = sec1 + ((Math.Pow((LN / MN), i)) / (ifact));
            }

            for(int n = s+1; n <= k; n++)
            {
                sec3 = sec3 + (Math.Pow((LN / (s * MN)), n - s));
            }
            sec2 = (Math.Pow((LN / MN), s)) / (sfact);
            P0 = 1 / (sec1 + sec2 * sec3);
            return P0;
        }

        public double Pn(int n, int s, double LN, double MN, double P0, int k)
        {
            double Pn;
            if (n > s)
            {
                Pn = (Math.Pow((LN / MN), n) / (factorial(s) * Math.Pow(s, n - s))) * P0;
            }
            else
            {
                Pn = (Math.Pow((LN / MN), n) / factorial(n)) * P0;
            }
            return Pn;
        }

        private void lambda_TextChanged(object sender, EventArgs e)
        {

        }

        private void miu_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lambda.Text.Any(Char.IsNumber) && miu.Text.Any(Char.IsNumber) &&
               double.Parse(lambda.Text) >= 0 && double.Parse(miu.Text) >= 0 &&
               servidores.Text.Any(Char.IsNumber) && int.Parse(servidores.Text) >= 0 &&
               clientes.Text.Any(Char.IsNumber) && int.Parse(clientes.Text) >= 0
               && listBox1.SelectedItem != null)
            //&&double.Parse(lambda.Text) >= double.Parse(miu.Text))
            {
                dataGridView1.Rows.Clear();
                string[] rows = new string[20000];
                

                double LN = double.Parse(lambda.Text);
                double MN = double.Parse(miu.Text);
                int Nclientes = int.Parse(clientes.Text);
                int S = int.Parse(servidores.Text);
                int K = int.Parse(kMax.Text);
                double P0val = Math.Round(P0(S, K, LN, MN), 4);
                double rho = Math.Round((LN / (MN * S)), 4);
                double Lq = Math.Round(((P0val * Math.Pow((LN / MN), S) * rho) / (factorial(S) * Math.Pow((1 - rho), 2))*(1-Math.Pow(rho,K-S)-(K-S)*(Math.Pow(rho, K - S))*(1-rho))), 4);
                
                string simbol = listBox1.SelectedItem.ToString();
                double PN = 0;

                if (simbol == "=")
                {
                    PN = Math.Round(Pn(Nclientes, S, LN, MN, P0val, K), 4);
                }
                if (simbol == ">")
                {
                    PN = P0val;
                    for (int i = 1; i <= Nclientes; i++)
                    {

                        PN = Math.Round(PN + Pn(i, S, LN, MN, P0val, K), 4);


                    }
                    PN = 1 - PN;
                }
                if (simbol == "<")
                {
                    PN = P0val;
                    for (int i = 1; i <= Nclientes; i++)
                    {
                        PN = Math.Round(PN + Pn(i, S, LN, MN, P0val, K), 4);

                    }
                }
                double pk = Math.Round(Pn(K, S, LN, MN, P0val, K), 4);

                double LE = LN*(1-pk);
                double Wq = Math.Round((Lq / LE), 4)*60;
                double W = Math.Round((Lq / LE) + (1 / MN), 4)*60;
                double L = Math.Round(LE * ((Lq / LE) + (1 / MN)), 4);
                if (Lq >= 0 && L >= 0)
                {
                    double ctotal = Lq * double.Parse(costocliente.Text) + S * double.Parse(costoservicio.Text);
                    dataGridView1.Visible = true;
                    string[] leyenda = { "ρ", "P0", "Pn" + simbol + Nclientes, "Lq", "Le", "Wq", "W", "L","CT" };
                    double[] valores = { rho, P0val, PN, Lq, LE, Wq, W, L,ctotal };
                    string[] des = {"Factor de utilización","Probabilidad de que haya 0 clientes en el sistema", "Probabilidad de que haya n clientes en el sistema",
                        "Número esperado de clientes en la cola", "Tasa de arribos efectiva", "Tiempo esperado de los clientes en la cola",
                        "Tiempo esperado de estancia de los clientes en el sistema", "Número esperado de clientes en el sistema","Costo total del servicio"
                        };
                    String[] unidades = { "","","", " clientes",""," minutos", " minutos", " clientes", " dolares" };


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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void servidores_TextChanged(object sender, EventArgs e)
        {

        }

        private void kMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
