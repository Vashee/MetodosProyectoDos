﻿namespace ProyectoFilas
{
    partial class MG1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minutosL = new System.Windows.Forms.Label();
            this.kL = new System.Windows.Forms.Label();
            this.sigmaL = new System.Windows.Forms.Label();
            this.distribuciones = new System.Windows.Forms.ListBox();
            this.desviacionS = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lambda = new System.Windows.Forms.TextBox();
            this.miu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoservicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costocliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.costoservicio);
            this.panel1.Controls.Add(this.minutosL);
            this.panel1.Controls.Add(this.kL);
            this.panel1.Controls.Add(this.sigmaL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.distribuciones);
            this.panel1.Controls.Add(this.costocliente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.desviacionS);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.clientes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lambda);
            this.panel1.Controls.Add(this.miu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 644);
            this.panel1.TabIndex = 9;
            // 
            // minutosL
            // 
            this.minutosL.AutoSize = true;
            this.minutosL.BackColor = System.Drawing.Color.Transparent;
            this.minutosL.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutosL.ForeColor = System.Drawing.Color.Black;
            this.minutosL.Location = new System.Drawing.Point(209, 172);
            this.minutosL.Name = "minutosL";
            this.minutosL.Size = new System.Drawing.Size(50, 27);
            this.minutosL.TabIndex = 26;
            this.minutosL.Text = "min";
            this.minutosL.Click += new System.EventHandler(this.minutosL_Click);
            // 
            // kL
            // 
            this.kL.AutoSize = true;
            this.kL.BackColor = System.Drawing.Color.Transparent;
            this.kL.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kL.ForeColor = System.Drawing.Color.Black;
            this.kL.Location = new System.Drawing.Point(116, 143);
            this.kL.Name = "kL";
            this.kL.Size = new System.Drawing.Size(24, 27);
            this.kL.TabIndex = 25;
            this.kL.Text = "k";
            this.kL.Click += new System.EventHandler(this.kL_Click);
            // 
            // sigmaL
            // 
            this.sigmaL.AutoSize = true;
            this.sigmaL.BackColor = System.Drawing.Color.Transparent;
            this.sigmaL.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmaL.ForeColor = System.Drawing.Color.Black;
            this.sigmaL.Location = new System.Drawing.Point(105, 143);
            this.sigmaL.Name = "sigmaL";
            this.sigmaL.Size = new System.Drawing.Size(46, 27);
            this.sigmaL.TabIndex = 24;
            this.sigmaL.Text = "σ^2";
            this.sigmaL.Click += new System.EventHandler(this.sigmaL_Click);
            // 
            // distribuciones
            // 
            this.distribuciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(201)))));
            this.distribuciones.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distribuciones.FormattingEnabled = true;
            this.distribuciones.ItemHeight = 21;
            this.distribuciones.Items.AddRange(new object[] {
            "Dist. General",
            "Dist. Erlang"});
            this.distribuciones.Location = new System.Drawing.Point(72, 224);
            this.distribuciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distribuciones.Name = "distribuciones";
            this.distribuciones.Size = new System.Drawing.Size(120, 46);
            this.distribuciones.TabIndex = 22;
            this.distribuciones.SelectedIndexChanged += new System.EventHandler(this.distribuciones_SelectedIndexChanged);
            // 
            // desviacionS
            // 
            this.desviacionS.Location = new System.Drawing.Point(59, 172);
            this.desviacionS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desviacionS.Name = "desviacionS";
            this.desviacionS.Size = new System.Drawing.Size(144, 22);
            this.desviacionS.TabIndex = 20;
            this.desviacionS.TextChanged += new System.EventHandler(this.desviacionS_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(201)))));
            this.listBox1.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.listBox1.Location = new System.Drawing.Point(23, 324);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(43, 67);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(135, 564);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 68);
            this.button2.TabIndex = 9;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clientes
            // 
            this.clientes.Location = new System.Drawing.Point(72, 350);
            this.clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(151, 22);
            this.clientes.TabIndex = 12;
            this.clientes.TextChanged += new System.EventHandler(this.clientes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tasa Media De Servicios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Número de clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasa Media De Llegadas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(4, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(13, 39);
            this.lambda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(249, 22);
            this.lambda.TabIndex = 3;
            this.lambda.TextChanged += new System.EventHandler(this.lambda_TextChanged);
            // 
            // miu
            // 
            this.miu.Location = new System.Drawing.Point(13, 107);
            this.miu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miu.Name = "miu";
            this.miu.Size = new System.Drawing.Size(249, 22);
            this.miu.TabIndex = 4;
            this.miu.TextChanged += new System.EventHandler(this.miu_TextChanged);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dato,
            this.Valor,
            this.Info});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(313, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 314);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dato
            // 
            this.Dato.HeaderText = "Dato";
            this.Dato.Name = "Dato";
            this.Dato.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 150;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.Width = 400;
            // 
            // costoservicio
            // 
            this.costoservicio.Location = new System.Drawing.Point(12, 517);
            this.costoservicio.Name = "costoservicio";
            this.costoservicio.Size = new System.Drawing.Size(250, 22);
            this.costoservicio.TabIndex = 29;
            this.costoservicio.TextChanged += new System.EventHandler(this.costoservicio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Costo por servicio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // costocliente
            // 
            this.costocliente.Location = new System.Drawing.Point(12, 440);
            this.costocliente.Name = "costocliente";
            this.costocliente.Size = new System.Drawing.Size(250, 22);
            this.costocliente.TabIndex = 27;
            this.costocliente.TextChanged += new System.EventHandler(this.costocliente_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "Costo cliente en final";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MG1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 643);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MG1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MG1";
            this.Load += new System.EventHandler(this.MG1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lambda;
        private System.Windows.Forms.TextBox miu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox desviacionS;
        private System.Windows.Forms.ListBox distribuciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.Label sigmaL;
        private System.Windows.Forms.Label kL;
        private System.Windows.Forms.Label minutosL;
        private System.Windows.Forms.TextBox costoservicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costocliente;
        private System.Windows.Forms.Label label6;
    }
}