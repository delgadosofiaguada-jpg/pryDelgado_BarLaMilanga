namespace pryDelgado_BarLaMilanga
{
    partial class frmBarMilanga
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarMilanga));
            lblTitulo = new Label();
            dgvResultados = new DataGridView();
            cmdValidarDatos = new Button();
            cmdTotales = new Button();
            cmdMozoDia = new Button();
            cmdCerrar = new Button();
            lblMozoDia = new Label();
            lblTotBebSAlcohol = new Label();
            lblTotBebAlcohol = new Label();
            lblTotComidas = new Label();
            lblTotalG = new Label();
            lblImporte = new Label();
            lblTotPostres = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de ventas diarias";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 55);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(739, 249);
            dgvResultados.TabIndex = 1;
            // 
            // cmdValidarDatos
            // 
            cmdValidarDatos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cmdValidarDatos.Location = new Point(379, 325);
            cmdValidarDatos.Name = "cmdValidarDatos";
            cmdValidarDatos.Size = new Size(106, 29);
            cmdValidarDatos.TabIndex = 2;
            cmdValidarDatos.Text = "Validar Datos";
            cmdValidarDatos.UseVisualStyleBackColor = true;
            cmdValidarDatos.Click += cmdValidarDatos_Click;
            // 
            // cmdTotales
            // 
            cmdTotales.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cmdTotales.Location = new Point(645, 325);
            cmdTotales.Name = "cmdTotales";
            cmdTotales.Size = new Size(106, 29);
            cmdTotales.TabIndex = 3;
            cmdTotales.Text = "Totales";
            cmdTotales.UseVisualStyleBackColor = true;
            cmdTotales.Click += button1_Click;
            // 
            // cmdMozoDia
            // 
            cmdMozoDia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cmdMozoDia.Location = new Point(511, 325);
            cmdMozoDia.Name = "cmdMozoDia";
            cmdMozoDia.Size = new Size(110, 29);
            cmdMozoDia.TabIndex = 4;
            cmdMozoDia.Text = "Mozo del Día";
            cmdMozoDia.UseVisualStyleBackColor = true;
            // 
            // cmdCerrar
            // 
            cmdCerrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCerrar.Location = new Point(645, 595);
            cmdCerrar.Name = "cmdCerrar";
            cmdCerrar.Size = new Size(106, 29);
            cmdCerrar.TabIndex = 5;
            cmdCerrar.Text = "Cerrar";
            cmdCerrar.UseVisualStyleBackColor = true;
            // 
            // lblMozoDia
            // 
            lblMozoDia.AutoSize = true;
            lblMozoDia.Location = new Point(420, 398);
            lblMozoDia.Name = "lblMozoDia";
            lblMozoDia.Size = new Size(99, 20);
            lblMozoDia.TabIndex = 6;
            lblMozoDia.Text = "Mozo del Día";
            // 
            // lblTotBebSAlcohol
            // 
            lblTotBebSAlcohol.AutoSize = true;
            lblTotBebSAlcohol.Location = new Point(25, 497);
            lblTotBebSAlcohol.Name = "lblTotBebSAlcohol";
            lblTotBebSAlcohol.Size = new Size(139, 20);
            lblTotBebSAlcohol.TabIndex = 7;
            lblTotBebSAlcohol.Text = "Bebidas sin Alcohol";
            // 
            // lblTotBebAlcohol
            // 
            lblTotBebAlcohol.AutoSize = true;
            lblTotBebAlcohol.Location = new Point(25, 448);
            lblTotBebAlcohol.Name = "lblTotBebAlcohol";
            lblTotBebAlcohol.Size = new Size(145, 20);
            lblTotBebAlcohol.TabIndex = 8;
            lblTotBebAlcohol.Text = "Bebidas con Alcohol";
            // 
            // lblTotComidas
            // 
            lblTotComidas.AutoSize = true;
            lblTotComidas.Location = new Point(60, 398);
            lblTotComidas.Name = "lblTotComidas";
            lblTotComidas.Size = new Size(104, 20);
            lblTotComidas.TabIndex = 9;
            lblTotComidas.Text = "Total Comidas";
            // 
            // lblTotalG
            // 
            lblTotalG.AutoSize = true;
            lblTotalG.Location = new Point(420, 509);
            lblTotalG.Name = "lblTotalG";
            lblTotalG.Size = new Size(97, 20);
            lblTotalG.TabIndex = 10;
            lblTotalG.Text = "Total General";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(455, 458);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(62, 20);
            lblImporte.TabIndex = 11;
            lblImporte.Text = "Importe";
            // 
            // lblTotPostres
            // 
            lblTotPostres.AutoSize = true;
            lblTotPostres.Location = new Point(109, 546);
            lblTotPostres.Name = "lblTotPostres";
            lblTotPostres.Size = new Size(55, 20);
            lblTotPostres.TabIndex = 12;
            lblTotPostres.Text = "Postres";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 391);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(546, 451);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(546, 391);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(185, 539);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(185, 490);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(185, 441);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(546, 502);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 19;
            // 
            // frmBarMilanga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 636);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTotPostres);
            Controls.Add(lblImporte);
            Controls.Add(lblTotalG);
            Controls.Add(lblTotComidas);
            Controls.Add(lblTotBebAlcohol);
            Controls.Add(lblTotBebSAlcohol);
            Controls.Add(lblMozoDia);
            Controls.Add(cmdCerrar);
            Controls.Add(cmdMozoDia);
            Controls.Add(cmdTotales);
            Controls.Add(cmdValidarDatos);
            Controls.Add(dgvResultados);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBarMilanga";
            Text = "Bar La Milanga";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvResultados;
        private Button cmdValidarDatos;
        private Button cmdTotales;
        private Button cmdMozoDia;
        private Button cmdCerrar;
        private Label lblMozoDia;
        private Label lblTotBebSAlcohol;
        private Label lblTotBebAlcohol;
        private Label lblTotComidas;
        private Label lblTotalG;
        private Label lblImporte;
        private Label lblTotPostres;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}
