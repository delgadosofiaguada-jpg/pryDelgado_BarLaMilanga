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
            clmComidas = new DataGridViewTextBoxColumn();
            clmPostres = new DataGridViewTextBoxColumn();
            clmBebidasCONAlcohol = new DataGridViewTextBoxColumn();
            clmBebidasSINAlcohol = new DataGridViewTextBoxColumn();
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
            txtbTOTComidas = new TextBox();
            txtbImporte = new TextBox();
            txtbMozoDia = new TextBox();
            txtbPostres = new TextBox();
            txtbBebSAlcohol = new TextBox();
            txtbBebAlcohol = new TextBox();
            txtbTotGeneral = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(10, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de ventas diarias";
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.BackgroundColor = SystemColors.ButtonFace;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { clmComidas, clmPostres, clmBebidasCONAlcohol, clmBebidasSINAlcohol });
            dgvResultados.Location = new Point(7, 41);
            dgvResultados.Margin = new Padding(3, 2, 3, 2);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(523, 187);
            dgvResultados.TabIndex = 1;
            // 
            // clmComidas
            // 
            clmComidas.HeaderText = "Comidas";
            clmComidas.MinimumWidth = 6;
            clmComidas.Name = "clmComidas";
            clmComidas.Width = 125;
            // 
            // clmPostres
            // 
            clmPostres.HeaderText = "Postres";
            clmPostres.MinimumWidth = 6;
            clmPostres.Name = "clmPostres";
            clmPostres.Width = 125;
            // 
            // clmBebidasCONAlcohol
            // 
            clmBebidasCONAlcohol.HeaderText = "Bebidas con alcohol";
            clmBebidasCONAlcohol.MinimumWidth = 6;
            clmBebidasCONAlcohol.Name = "clmBebidasCONAlcohol";
            clmBebidasCONAlcohol.Width = 125;
            // 
            // clmBebidasSINAlcohol
            // 
            clmBebidasSINAlcohol.HeaderText = "Bebidas sin alcohol";
            clmBebidasSINAlcohol.MinimumWidth = 6;
            clmBebidasSINAlcohol.Name = "clmBebidasSINAlcohol";
            clmBebidasSINAlcohol.Width = 125;
            // 
            // cmdValidarDatos
            // 
            cmdValidarDatos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdValidarDatos.Location = new Point(7, 246);
            cmdValidarDatos.Margin = new Padding(3, 2, 3, 2);
            cmdValidarDatos.Name = "cmdValidarDatos";
            cmdValidarDatos.Size = new Size(93, 31);
            cmdValidarDatos.TabIndex = 2;
            cmdValidarDatos.Text = "Validar Datos";
            cmdValidarDatos.UseVisualStyleBackColor = true;
            cmdValidarDatos.Click += cmdValidarDatos_Click;
            // 
            // cmdTotales
            // 
            cmdTotales.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdTotales.Location = new Point(120, 246);
            cmdTotales.Margin = new Padding(3, 2, 3, 2);
            cmdTotales.Name = "cmdTotales";
            cmdTotales.Size = new Size(93, 31);
            cmdTotales.TabIndex = 3;
            cmdTotales.Text = "Totales";
            cmdTotales.UseVisualStyleBackColor = true;
            cmdTotales.Click += cmdTotales_Click;
            // 
            // cmdMozoDia
            // 
            cmdMozoDia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdMozoDia.Location = new Point(310, 246);
            cmdMozoDia.Margin = new Padding(3, 2, 3, 2);
            cmdMozoDia.Name = "cmdMozoDia";
            cmdMozoDia.Size = new Size(112, 31);
            cmdMozoDia.TabIndex = 4;
            cmdMozoDia.Text = "Mozo del Día";
            cmdMozoDia.UseVisualStyleBackColor = true;
            cmdMozoDia.Click += cmdMozoDia_Click;
            // 
            // cmdCerrar
            // 
            cmdCerrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCerrar.Location = new Point(420, 475);
            cmdCerrar.Margin = new Padding(3, 2, 3, 2);
            cmdCerrar.Name = "cmdCerrar";
            cmdCerrar.Size = new Size(93, 28);
            cmdCerrar.TabIndex = 5;
            cmdCerrar.Text = "Cerrar";
            cmdCerrar.UseVisualStyleBackColor = true;
            cmdCerrar.Click += cmdCerrar_Click;
            // 
            // lblMozoDia
            // 
            lblMozoDia.AutoSize = true;
            lblMozoDia.Location = new Point(310, 298);
            lblMozoDia.Name = "lblMozoDia";
            lblMozoDia.Size = new Size(76, 15);
            lblMozoDia.TabIndex = 6;
            lblMozoDia.Text = "Mozo del Día";
            // 
            // lblTotBebSAlcohol
            // 
            lblTotBebSAlcohol.AutoSize = true;
            lblTotBebSAlcohol.Location = new Point(1, 373);
            lblTotBebSAlcohol.Name = "lblTotBebSAlcohol";
            lblTotBebSAlcohol.Size = new Size(110, 15);
            lblTotBebSAlcohol.TabIndex = 7;
            lblTotBebSAlcohol.Text = "Bebidas sin Alcohol";
            // 
            // lblTotBebAlcohol
            // 
            lblTotBebAlcohol.AutoSize = true;
            lblTotBebAlcohol.Location = new Point(1, 336);
            lblTotBebAlcohol.Name = "lblTotBebAlcohol";
            lblTotBebAlcohol.Size = new Size(115, 15);
            lblTotBebAlcohol.TabIndex = 8;
            lblTotBebAlcohol.Text = "Bebidas con Alcohol";
            // 
            // lblTotComidas
            // 
            lblTotComidas.AutoSize = true;
            lblTotComidas.Location = new Point(32, 298);
            lblTotComidas.Name = "lblTotComidas";
            lblTotComidas.Size = new Size(82, 15);
            lblTotComidas.TabIndex = 9;
            lblTotComidas.Text = "Total Comidas";
            // 
            // lblTotalG
            // 
            lblTotalG.AutoSize = true;
            lblTotalG.Location = new Point(32, 452);
            lblTotalG.Name = "lblTotalG";
            lblTotalG.Size = new Size(75, 15);
            lblTotalG.TabIndex = 10;
            lblTotalG.Text = "Total General";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(342, 335);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(49, 15);
            lblImporte.TabIndex = 11;
            lblImporte.Text = "Importe";
            // 
            // lblTotPostres
            // 
            lblTotPostres.AutoSize = true;
            lblTotPostres.Location = new Point(74, 413);
            lblTotPostres.Name = "lblTotPostres";
            lblTotPostres.Size = new Size(45, 15);
            lblTotPostres.TabIndex = 12;
            lblTotPostres.Text = "Postres";
            // 
            // txtbTOTComidas
            // 
            txtbTOTComidas.Location = new Point(141, 293);
            txtbTOTComidas.Margin = new Padding(3, 2, 3, 2);
            txtbTOTComidas.Name = "txtbTOTComidas";
            txtbTOTComidas.Size = new Size(110, 23);
            txtbTOTComidas.TabIndex = 13;
            // 
            // txtbImporte
            // 
            txtbImporte.Location = new Point(420, 330);
            txtbImporte.Margin = new Padding(3, 2, 3, 2);
            txtbImporte.Name = "txtbImporte";
            txtbImporte.Size = new Size(110, 23);
            txtbImporte.TabIndex = 14;
            // 
            // txtbMozoDia
            // 
            txtbMozoDia.Location = new Point(420, 293);
            txtbMozoDia.Margin = new Padding(3, 2, 3, 2);
            txtbMozoDia.Name = "txtbMozoDia";
            txtbMozoDia.Size = new Size(110, 23);
            txtbMozoDia.TabIndex = 15;
            // 
            // txtbPostres
            // 
            txtbPostres.Location = new Point(141, 408);
            txtbPostres.Margin = new Padding(3, 2, 3, 2);
            txtbPostres.Name = "txtbPostres";
            txtbPostres.Size = new Size(110, 23);
            txtbPostres.TabIndex = 16;
            // 
            // txtbBebSAlcohol
            // 
            txtbBebSAlcohol.Location = new Point(141, 368);
            txtbBebSAlcohol.Margin = new Padding(3, 2, 3, 2);
            txtbBebSAlcohol.Name = "txtbBebSAlcohol";
            txtbBebSAlcohol.Size = new Size(110, 23);
            txtbBebSAlcohol.TabIndex = 17;
            // 
            // txtbBebAlcohol
            // 
            txtbBebAlcohol.Location = new Point(141, 331);
            txtbBebAlcohol.Margin = new Padding(3, 2, 3, 2);
            txtbBebAlcohol.Name = "txtbBebAlcohol";
            txtbBebAlcohol.Size = new Size(110, 23);
            txtbBebAlcohol.TabIndex = 18;
            // 
            // txtbTotGeneral
            // 
            txtbTotGeneral.Location = new Point(142, 447);
            txtbTotGeneral.Margin = new Padding(3, 2, 3, 2);
            txtbTotGeneral.Name = "txtbTotGeneral";
            txtbTotGeneral.Size = new Size(110, 23);
            txtbTotGeneral.TabIndex = 19;
            // 
            // frmBarMilanga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 509);
            Controls.Add(txtbTotGeneral);
            Controls.Add(txtbBebAlcohol);
            Controls.Add(txtbBebSAlcohol);
            Controls.Add(txtbPostres);
            Controls.Add(txtbMozoDia);
            Controls.Add(txtbImporte);
            Controls.Add(txtbTOTComidas);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBarMilanga";
            Text = "Bar La Milanga";
            Load += frmBarMilanga_Load;
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
        private TextBox txtbTOTComidas;
        private TextBox txtbImporte;
        private TextBox txtbMozoDia;
        private TextBox txtbPostres;
        private TextBox txtbBebSAlcohol;
        private TextBox txtbBebAlcohol;
        private TextBox txtbTotGeneral;
        private DataGridViewTextBoxColumn clmComidas;
        private DataGridViewTextBoxColumn clmPostres;
        private DataGridViewTextBoxColumn clmBebidasCONAlcohol;
        private DataGridViewTextBoxColumn clmBebidasSINAlcohol;
    }
}
