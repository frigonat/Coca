using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coca
{
    public partial class frmConfirmaciones : Form
    {
        private Dictionary<string, string> tiposDeDocumento;

        public frmConfirmaciones()
        {
            InitializeComponent();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            int totalDePallets = 0;
            int totalDeCajas = 0;
            int totalDeUnidades = 0;
            int i = 0;
            List<Confirmacion> confirmaciones;

            Cursor.Current = Cursors.WaitCursor;

            if (txtNumeroDeLote.TextLength > 0)
                confirmaciones = Confirmacion.Obtener(dtpFechaDesde.Value, dtpFechaHasta.Value, txtNumeroDeLote.Text);
            else
                confirmaciones = Confirmacion.Obtener(dtpFechaDesde.Value, dtpFechaHasta.Value);

            //Si se especificó el filtro por Estado, se aplica.-
            if (cmbEstados.Text != "*Todos")
                confirmaciones.RemoveAll(item => item.Estado.ToString() != cmbEstados.Text);

            //Si se especificó el filtro x Tipo de Documento, se aplica.-
            if (cmbTiposDeDocumento.Text != "*Todos")
                confirmaciones.RemoveAll(item => item.Tipo.Descripcion.ToString() != cmbTiposDeDocumento.Text);

            //Si se especificó el filtro x Cliente, se aplica.-
            if (cmbClientes.Text != "*Todos")
                confirmaciones.RemoveAll(item => item.NombreDeAlmacen != cmbClientes.Text);
           
            dgvConfirmaciones.Rows.Clear();
            object[] valores = new object[16];

            foreach (Confirmacion c in confirmaciones)
            {
                valores[0] = c.CodigoDeAlmacen;
                valores[1] = c.NombreDeAlmacen;
                valores[2] = c.Tipo.Descripcion;
                valores[3] = c.Numero.ToString();
                valores[4] = c.NumeroNotaFiscal.ToString();
                valores[5] = c.NumeroDocumentoDeEntrada.ToString();
                valores[6] = c.Estado;
                valores[7] = c.Evento;
                valores[8] = c.FechaHoraDeAlta.ToString("dd-MM-yyyy");
                valores[9] = c.UsuarioDeAlta;
                valores[10] = c.NombreArchivoDeTransmision;
                valores[11] = c.FechaHoraDeProceso.ToString("dd-MM-yyyy");
                valores[12] = c.UsuarioDeProceso;
                valores[13] = c.CantidadDePallets;
                valores[14] = c.CantidadDeCajas;
                valores[15] = c.CantidadDeUnidades;
                dgvConfirmaciones.Rows.Add(valores);

                if (c.NombreDeAlmacen == "Almacén no encontrado")
                {
                    dgvConfirmaciones.Rows[i].Cells[colConfirmacionAlmacen.Name].Style.BackColor = Color.LemonChiffon;
                    dgvConfirmaciones.Rows[i].Cells[colConfirmacionNombreAlmacen.Name].Style.BackColor = Color.LemonChiffon;
                }

                i++;

                totalDePallets += c.CantidadDePallets;
                totalDeCajas += c.CantidadDeCajas;
                totalDeUnidades += c.CantidadDeUnidades;
            }


            NumberFormatInfo nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSeparator = ".";

            lblTotalPallets.Text = totalDePallets.ToString("N", nfi);
            lblTotalCajas.Text = totalDeCajas.ToString("N", nfi);
            lblTotalUnidades.Text = totalDeUnidades.ToString("N", nfi);

            tslCantidadDeConfirmaciones.Text = dgvConfirmaciones.Rows.Count.ToString();

            Cursor.Current = Cursors.Default;
        }

        private void frmConfirmaciones_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-2);
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddDays(+1);

            tiposDeDocumento = new Dictionary<string, string>();
            tiposDeDocumento = TipoDeDocumento.Obtener();

            cmbTiposDeDocumento.Items.Add("*Todos");

            foreach (KeyValuePair<string, string> kvp in tiposDeDocumento)
                cmbTiposDeDocumento.Items.Add(kvp.Key);

            cmbTiposDeDocumento.SelectedIndex = 0;

            lblTotalPallets.Text = "0";
            lblTotalCajas.Text = "0";
            lblTotalUnidades.Text = "0";

            dtpFechaDesde.Value = DateTime.Now.AddDays(-1);
            dtpFechaHasta.Value = DateTime.Now;

            cmbEstados.Items.Add("*Todos");

            List<string> estados = new List<string>();
            foreach (string unEstado in Enum.GetNames(typeof(EstadosDeDocumento)))
                cmbEstados.Items.Add(unEstado);
            cmbEstados.SelectedIndex = 0;

            cmbClientes.Items.Add("*Todos");
            List<Almacen> almacenes = new List<Almacen>();
            almacenes = Almacen.Obtener();
            foreach (Almacen a in almacenes)
                cmbClientes.Items.Add(a.Nombre);
            cmbClientes.SelectedIndex = 0;
        }

        private void dtpFechaDesde_Leave(object sender, EventArgs e)
        {
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddDays(1);
        }

        private void dgvConfirmaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoAlmacenDocumentoSeleccionado = dgvConfirmaciones.CurrentRow.Cells[colConfirmacionAlmacen.Name].Value.ToString();
            string tipoDocumentoSeleccionado = "I";
            int numeroDocumentoSeleccionado = System.Convert.ToInt32(dgvConfirmaciones.CurrentRow.Cells[colConfirmacionNumero.Name].Value);
            tiposDeDocumento.TryGetValue(dgvConfirmaciones.CurrentRow.Cells[colConfirmacionTipoDocumento.Name].Value.ToString(), out tipoDocumentoSeleccionado);
            
            frmDocumentoConfirmacion f = new frmDocumentoConfirmacion();

            f.Mostrar(new Confirmacion(codigoAlmacenDocumentoSeleccionado, tipoDocumentoSeleccionado, numeroDocumentoSeleccionado));
        }
    }
}
