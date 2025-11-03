namespace pryDelgado_BarLaMilanga
{
    public partial class frmBarMilanga : Form
    {
        public frmBarMilanga()
        {
            InitializeComponent();
        }

        float[,] Ventas = new float[5, 4]; // 5 mozos x 4 categorías
        string[] Mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        string[] Categorias = { "Comidas", "Bebidas sin alcohol", "Bebidas con alcohol", "Postres" };

        private void frmBarMilanga_Load(object sender, EventArgs e)
        {
            cmdMozoDia.Enabled = false;
            cmdTotales.Enabled = false;

            dgvResultados.ColumnCount = 4; //Columnas
            dgvResultados.RowCount = 5; //Filas

            dgvResultados.Columns[0].HeaderText = "Comidas";
            dgvResultados.Columns[1].HeaderText = "Bebidas sin alcohol";
            dgvResultados.Columns[2].HeaderText = "Bebidas con alcohol";
            dgvResultados.Columns[3].HeaderText = "Postres";

            string[] Mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
            for (int i = 0; i < 5; i++)
            {
                dgvResultados.Rows[i].HeaderCell.Value = Mozos[i]; //Al recorrer las filas coloca los nombre de los mozos
            }
        }

        private void cmdValidarDatos_Click(object sender, EventArgs e)
        {
            bool valido = true;

            for (int f = 0; f < 5; f++) //Recorro las filas
            {
                for (int c = 0; c < 4; c++) //Recorro las columnas
                {
                    string valor = Convert.ToString(dgvResultados.Rows[f].Cells[c].Value);

                    if (valor == "") 
                    {
                        valido = false;
                        break;
                    }

                    try // Intento convertir el valor a float
                    {
                        Ventas[f, c] = float.Parse(valor);
                    }
                    catch 
                    {
                        valido = false;
                        break;
                    }
                }
            }
            if (!valido) // Si algún dato no es válido
            {
                MessageBox.Show("Error al cargar los datos: Los valores deben ser numéricos válidos.");
                cmdMozoDia.Enabled = false;
                cmdTotales.Enabled = false;
            }
            else
            {
                MessageBox.Show("Datos validados.");
                cmdMozoDia.Enabled = true;
                cmdTotales.Enabled = true;
            }
        }

        private void cmdMozoDia_Click(object sender, EventArgs e)
        {
            int MozoDia = 0;
            float VentaMayor = 0;

            for (int f = 0; f < 5; f++)
            {
                float TotMozo = 0;
                for (int c = 0; c < 4; c++)
                {
                    TotMozo += Ventas[f, c];
                }

                if (TotMozo > VentaMayor)
                {
                    VentaMayor = TotMozo;
                    MozoDia = f;
                }
            }

            txtbMozoDia.Text = Mozos[MozoDia]; // Nombre del mozo con mayor venta
            txtbImporte.Text = VentaMayor.ToString("0.00"); // Importe total vendido por el mozo
        }

        private void cmdTotales_Click(object sender, EventArgs e)
        {
            float TotGeneral = 0;
            float[] TotCategoria = new float[4];

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    TotGeneral += Ventas[f, c];
                    TotCategoria[c] += Ventas[f, c];
                }
            }

            txtbTotGeneral.Text = TotGeneral.ToString("0.00");
            txtbTOTComidas.Text = TotCategoria[0].ToString("0.00");
            txtbBebSAlcohol.Text = TotCategoria[1].ToString("0.00");
            txtbBebAlcohol.Text = TotCategoria[2].ToString("0.00");
            txtbPostres.Text = TotCategoria[3].ToString("0.00");
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
} 
