using PruebaTecnica_Colcar.Data;
using PruebaTecnica_Colcar.Model;

namespace PruebaTecnica_Colcar
{
    public partial class Multas_Form : Form
    {

        public Multas_Form()
        {
            InitializeComponent();

            cargarMultas();

            dgvMultas.CellFormatting += dgvMultas_CellFormatting;
            dgvMultas.CellContentClick += CambiarPagoButtonClick;
            dgvMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMultas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMultas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMultas.Columns["identificador_infraccion"].HeaderText = "ID DE MULTA";
            dgvMultas.Columns["dni"].HeaderText = "DNI";
            dgvMultas.Columns["fecha_infraccion"].HeaderText = "FECHA DE EMISION";
            dgvMultas.Columns["importe"].HeaderText = "IMPORTE";
            dgvMultas.Columns["fecha_pago"].HeaderText = "FECHA DE PAGO";

        }

        private void cargarMultas()
        {
            dgvMultas.DataSource = PersistenciaDeDatos.OrdenarPorFechaDescendente();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void dgvMultas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMultas.Columns["PonerFechaPago"].Index)
            {
              
                var listaMultasOrdenadas = PersistenciaDeDatos.OrdenarPorFechaDescendente();                
                var multa = listaMultasOrdenadas[e.RowIndex];

                if (multa.fecha_pago == null)
                {
                    e.Value = "Cambiar a Pagado";
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }


        private void CambiarPagoButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMultas.Columns["PonerFechaPago"].Index)
            {
                DataGridViewRow row = dgvMultas.Rows[e.RowIndex];
                Multa multa = row.DataBoundItem as Multa;

                if (multa != null)
                {
                    if (!multa.fecha_pago.HasValue || multa.fecha_pago == DateTime.MinValue)
                    {
                        DateTime fechaSeleccionada = calendar.SelectionStart;
                        multa.fecha_pago = fechaSeleccionada;
                        row.Cells["fecha_pago"].Value = fechaSeleccionada;

                        dgvMultas.Invalidate();
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(txtDni.Text);
                dgvMultas.DataSource = PersistenciaDeDatos.FiltrarYOrdenarPorDNI(Convert.ToInt32(txtDni.Text));
            }
            catch (Exception)
            {
            }


        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cargarMultas();
        }
    }
}