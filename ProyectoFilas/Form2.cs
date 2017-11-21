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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); //hola todos
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MG1 f4 = new MG1();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f5 = new Form5();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
