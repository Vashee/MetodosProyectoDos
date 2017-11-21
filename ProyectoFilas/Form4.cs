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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lambda_TextChanged(object sender, EventArgs e)
        {

        }

        private void miu_TextChanged(object sender, EventArgs e)
        {

        }

        private void desviacionS_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lambda.Text.Any(Char.IsNumber) && miu.Text.Any(Char.IsNumber) &&
                double.Parse(lambda.Text)>=0 && double.Parse(miu.Text)>=0 &&
               clientes.Text.Any(Char.IsNumber) && int.Parse(clientes.Text) >= 0 &&
               desviacionS.Text.Any(Char.IsNumber) && double.Parse(desviacionS.Text) >= 0
               && listBox1.SelectedItem != null && distribuciones.SelectedItem != null)
            {
                dataGridView1.Rows.Clear();
                int Nclientes = int.Parse(clientes.Text);
                string tipoDist = distribuciones.SelectedItem.ToString();
                string simbol = listBox1.SelectedItem.ToString();
                string simboMsg = "";
                if (simbol == ">")
                {
                    simboMsg = "más de ";
                }
                else if (simbol == "<")
                {
                    simboMsg = "a lo mucho ";
                }
                string[] rows = new string[20000];
                string[] leyenda = {"ρ", "σ", "Lq", "L", "Wq", "W", "P0","Pn" + simbol + Nclientes };
                string[] des = {"Factor de utilización",
                "Desviacion estándar",
                "Clientes esperados en la cola",
                "Clientes esperados en el sistema",
                "Tiempo esperado (en minutos)" + "\r de los clientes en la cola",
                "Tiempo esperado (en minutos)" + "\r de los clientes en el sistema",
                "Probabilidad de que haya cero clientes en el sistema",
                "Probabilidad de que haya " + simboMsg + Nclientes + " clientes en el sistema" };
                double  LN = double.Parse(lambda.Text);
                double  MN = double.Parse(miu.Text);
                double DS = double.Parse(desviacionS.Text);
                double rho = Math.Round((LN / MN), 4);
                double sigmaDS = 0.0;
                double L = 0.0;
                double Lq = 0.0;
                double Wq = 0.0;
                double W = 0.0;

                if (tipoDist == "Dist. Erlang")
                {
                    sigmaDS = Math.Round((1 / Math.Sqrt(DS)) * (1 / MN), 4);
                    Lq = Math.Round((((LN * LN) * (sigmaDS * sigmaDS)) + (rho * rho)) / (2 * (1 - rho)), 4);
                    Wq = Math.Round((Lq / LN) * 60, 4);
                    W = Math.Round(((Lq / LN) + (1 / MN)) * 60, 4);
                    L = Math.Round(LN * W, 4);
                }
                else if (tipoDist == "Dist. General")
                {
                    sigmaDS = Math.Round(DS / 60, 4);
                    Lq = Math.Round((((LN * LN) * (sigmaDS * sigmaDS)) + (rho * rho)) / (2 * (1 - rho)), 4);
                    L = Math.Round(rho + Lq, 4);
                    Wq = Math.Round((Lq / LN) * 60, 4);
                    W = Math.Round(((Lq / LN) + (1 / MN)) * 60, 4);
                }
                
                double P0 = Math.Round(1 - rho, 4);
                double PN = 0;

                if (simbol == "=")
                {
                    PN = Math.Round(P0 * Math.Pow(rho, Nclientes), 4);
                }
                if (simbol == ">")
                {
                    for (int i = 0; i <= Nclientes; i++)
                    {
                        PN += Math.Round(P0 * Math.Pow(rho, Nclientes), 4);
                    }
                    PN = 1 - PN;
                }
                if (simbol == "<")
                {
                    for (int i = 1; i <= Nclientes; i++)
                    {
                        PN = PN + Math.Round(P0 * Math.Pow(rho, Nclientes), 4);

                    }
                }

                if (Lq >= 0 && L >= 0)
                {
                    dataGridView1.Visible = true;
                    double[] valores = { rho, sigmaDS, Lq, L, Wq, W, P0, PN };
                    String[] unidades = { "", "", " clientes", " clientes", " minutos", " minutos", "","" };

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
            if (distribuciones.SelectedItem == null)
            {
                MessageBox.Show("Favor de escoger un tipo de distribución");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void distribuciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
