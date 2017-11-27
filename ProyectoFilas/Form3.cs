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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        public  double factorial(int n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public  double P0(int s, double LN, double MN)
        {
            double P0 = 0;
            double sec1 = 0, sec2, sec3, ifact, sfact;
            sfact = factorial(s);

            for (int i = 0; i <= s-1; i++)
            {
                ifact = factorial(i);
                sec1 = sec1+(Math.Pow((LN / MN), i)) / (ifact);
            }
            sec2 = (Math.Pow((LN / MN), s)) / (sfact);
            sec3 = 1 / (1 - (LN / (s * MN)));
            P0 = 1/(sec1 + sec2 * sec3);
            return P0;
        }

        public double Pn(int n,int s, double LN, double MN, double P0)
        {
            double Pn;
            if (n > s)
            {
                Pn = (Math.Pow((LN / MN), n) / (factorial(s) * Math.Pow(s, n - s))) * P0;
            }
            else
            {
                Pn = (Math.Pow((LN / MN), n) / factorial(n))*P0;
            }
            return Pn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lambda.Text.Any(Char.IsNumber) && miu.Text.Any(Char.IsNumber) &&
               double.Parse(lambda.Text) >= 0 && double.Parse(miu.Text) >= 0 &&
               servidores.Text.Any(Char.IsNumber) && int.Parse(servidores.Text) >= 0 &&
               clientes.Text.Any(Char.IsNumber) && int.Parse(clientes.Text) >= 0
               && listBox1.SelectedItem != null
               &&
                costocliente.Text.Any(Char.IsNumber) && costoservicio.Text.Any(Char.IsNumber) &&
                double.Parse(costoservicio.Text) >= 0 && double.Parse(costocliente.Text) >= 0
               )
                //&&double.Parse(lambda.Text) >= double.Parse(miu.Text))
               
       
            {
                dataGridView1.Rows.Clear();
                string[] rows = new string[20000];
                string[] des = {"Factor de utilización","Clientes esperados en el sistema",
                "Clientes en el sistema","Probabilidad de que haya cero clientes en el sistema","Probabilidad de que haya n clientes en el sistema",
                    "Tiempo esperado de los clientes en la cola","Tiempo esperado de estancia de" +
                "los clientes en el sistema","Costo total del servicio"};
                double LN = double.Parse(lambda.Text);
                double MN = double.Parse(miu.Text);
                int Nclientes = int.Parse(clientes.Text);
                int S = int.Parse(servidores.Text);
                double P0val = Math.Round(P0(S, LN, MN),4);
                double rho = Math.Round((LN / (MN*S)), 4);
                double Lq = Math.Round((P0val*Math.Pow((LN/MN),S)*rho)/(factorial(S)*Math.Pow((1-rho),2)), 4);
                double L = Math.Round(Lq+(LN/MN), 4);
                string simbol = listBox1.SelectedItem.ToString();
                double PN = 0;
                if (simbol == "=")
                {
                     PN = Math.Round(Pn(Nclientes, S, LN, MN, P0val),4);
                }
                if (simbol == ">")
                {
                    PN = P0val;
                    for(int i =1;i<=Nclientes;i++)
                    {
                        
                        PN = Math.Round(PN + Pn(i, S, LN, MN, P0val),4);


                    }
                    PN = 1 - PN;
                }
                if (simbol == "<")
                {
                    PN = P0val;
                    for (int i = 1; i <= Nclientes; i++)
                    {
                        PN = Math.Round(PN + Pn(i, S, LN, MN, P0val), 4);

                    }
                }

                    double Wq = Math.Round((Lq/LN), 4)*60;
                    double W = Math.Round((Lq/LN)+(1/MN), 4)*60;
                    if (Lq >= 0 && L >= 0)
                {
                    dataGridView1.Visible = true;
                    double ctotal = (Lq * double.Parse(costocliente.Text)) + (S*double.Parse(costoservicio.Text));
                    string[] leyenda = { "ρ", "Lq", "L", "P0", "PN" + simbol + Nclientes, "Wq", "W","CT" };
                    double[] valores = { rho, Lq, L,P0val,PN,Wq,W,ctotal};
                    String[] unidades = { "", " clientes", " clientes", "","", " minutos", " minutos", ""," dolares" };

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

        private void servidores_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void costoservicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void costocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
