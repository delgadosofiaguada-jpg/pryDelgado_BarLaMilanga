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
            dgvResultados.ColumnCount = 4;
            dgvResultados.RowCount = 5;

            dgvResultados.Columns[0].HeaderText = "Comidas";
            dgvResultados.Columns[1].HeaderText = "Bebidas sin alcohol";
            dgvResultados.Columns[2].HeaderText = "Bebidas con alcohol";
            dgvResultados.Columns[3].HeaderText = "Postres";

            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
            for (int i = 0; i < 5; i++)
            {
                dgvResultados.Rows[i].HeaderCell.Value = mozos[i];
            }
            cmdMozoDia.Enabled = false;
            cmdTotales.Enabled = false;
        }

        private void cmdValidarDatos_Click(object sender, EventArgs e)
        {
            bool valido = true;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    string valor = Convert.ToString(dgvResultados.Rows[f].Cells[c].Value);

                    if (valor == "")
                    {
                        valido = false;
                        break;
                    }

                    try
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
            if (!valido)
            {
                MessageBox.Show("Error: Verifique que todas las celdas contengan valores numéricos válidos (puede usar 0).");
                cmdMozoDia.Enabled = false;
                cmdTotales.Enabled = false;
            }
            else
            {
                MessageBox.Show("Datos validados correctamente.");
                cmdMozoDia.Enabled = true;
                cmdTotales.Enabled = true;
            }
        }

        private void cmdMozoDia_Click(object sender, EventArgs e)
        {
            int mejorMozo = 0;
            float mayorVenta = 0;

            for (int f = 0; f < 5; f++)
            {
                float totalMozo = 0;
                for (int c = 0; c < 4; c++)
                {
                    totalMozo += Ventas[f, c];
                }

                if (totalMozo > mayorVenta)
                {
                    mayorVenta = totalMozo;
                    mejorMozo = f;
                }
            }

            txtbMozoDia.Text = Mozos[mejorMozo];
            txtbImporte.Text = mayorVenta.ToString("0.00");
        }

        private void cmdTotales_Click(object sender, EventArgs e)
        {
            float totalGeneral = 0;
            float[] totalPorCategoria = new float[4];

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    totalGeneral += Ventas[f, c];
                    totalPorCategoria[c] += Ventas[f, c];
                }
            }

            txtbTotGeneral.Text = totalGeneral.ToString("0.00");
            txtbTOTComidas.Text = totalPorCategoria[0].ToString("0.00");
            txtbBebSAlcohol.Text = totalPorCategoria[1].ToString("0.00");
            txtbBebAlcohol.Text = totalPorCategoria[2].ToString("0.00");
            txtbPostres.Text = totalPorCategoria[3].ToString("0.00");
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbImporte_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
