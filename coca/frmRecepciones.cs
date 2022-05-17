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
    public partial class frmRecepciones : Form
    {
        private Dictionary<string, string> tiposDeDocumento;
        public frmRecepciones()
        {
            InitializeComponent();
        }

        private void frmRecepciones_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-2);
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddDays(+1);

            tiposDeDocumento = new Dictionary<string, string>();
            tiposDeDocumento = TipoDeDocumento.Obtener();

            lblTotalPallets.Text = "0";
            lblTotalCajas.Text = "0";
            lblTotalUnidades.Text = "0";

            dtpFechaDesde.Value = DateTime.Now.AddDays(-1);
            dtpFechaHasta.Value = DateTime.Now;


            cmbTiposDeDocumento.Items.Add("*Todos");
            foreach (KeyValuePair<string, string> kvp in tiposDeDocumento)
                cmbTiposDeDocumento.Items.Add(kvp.Key);

            cmbTiposDeDocumento.SelectedIndex = 0;

            cmbClientes.Items.Add("*Todos");
            List<Almacen> almacenes = Almacen.Obtener();
            foreach (Almacen a in almacenes)
                cmbClientes.Items.Add(a.Nombre);
            cmbClientes.SelectedIndex = 0;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            int totalDePallets = 0;
            int totalDeCajas = 0;
            int totalDeUnidades = 0;
            int i = 0;
            List<Documento> documentos;

            Cursor.Current = Cursors.WaitCursor;

            if (txtNumeroDeLote.TextLength > 0)
                documentos = Documento.Obtener(dtpFechaDesde.Value, dtpFechaHasta.Value, txtNumeroDeLote.Text);
            else
                documentos = Documento.Obtener(dtpFechaDesde.Value, dtpFechaHasta.Value);

            //Si se especificó el filtro x Tipo de Documento, se aplica.-
            if (cmbTiposDeDocumento.Text != "*Todos")
                documentos.RemoveAll(item => item.Tipo.Descripcion.ToString() != cmbTiposDeDocumento.Text);

            //Si se especificó el filtro x Cliente, se aplica.-
            if (cmbClientes.Text != "*Todos")
                documentos.RemoveAll(item => item.NombreDeAlmacen != cmbClientes.Text);

            dgvRecepciones.Rows.Clear();
            object[] valores = new object[13];

            foreach (Documento d in documentos)
            {
                valores[0] = d.CodigoDeAlmacen;
                valores[1] = d.NombreDeAlmacen;
                valores[2] = d.Tipo.Descripcion;
                valores[3] = d.Numero.ToString();
                valores[4] = d.NumeroDocumentoDeEntrada.ToString();
                valores[5] = d.NumeroNotaFiscal.ToString();
                valores[6] = d.Estado;
                valores[7] = d.FechaHoraDeAlta.ToString("dd-MM-yyyy");
                valores[8] = d.FechaHoraDeAlta.ToString("HH.mm.ss");
                valores[9] = d.NombreArchivoDeTransmision;
                valores[10] = d.CantidadDePallets;
                valores[11] = d.CantidadDeCajas;
                valores[12] = d.CantidadDeUnidades;
                dgvRecepciones.Rows.Add(valores);

                if (d.NombreDeAlmacen == "Almacén no encontrado")
                {
                    dgvRecepciones.Rows[i].Cells[colRecepcionAlmacen.Name].Style.BackColor = Color.LemonChiffon;
                    dgvRecepciones.Rows[i].Cells[colRececpcionNombreAlmacen.Name].Style.BackColor = Color.LemonChiffon;
                }

                i++;

                totalDePallets += d.CantidadDePallets;
                totalDeCajas += d.CantidadDeCajas;
                totalDeUnidades += d.CantidadDeUnidades;
            }


            NumberFormatInfo nfi = (NumberFormatInfo) CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSeparator = "."; 

            lblTotalPallets.Text = totalDePallets.ToString("N", nfi);
            lblTotalCajas.Text = totalDeCajas.ToString("N", nfi);
            lblTotalUnidades.Text = totalDeUnidades.ToString("N",nfi);

            tslCantidadDeRecepciones.Text = dgvRecepciones.Rows.Count.ToString();

            Cursor.Current = Cursors.Default;
        }

        private void dgvRecepciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoAlmacenDocumentoSeleccionado = dgvRecepciones.CurrentRow.Cells[colRecepcionAlmacen.Name].Value.ToString();
            string tipoDocumentoSeleccionado = "I";
            int numeroDocumentoSeleccionado = System.Convert.ToInt32(dgvRecepciones.CurrentRow.Cells[colRecepcionNumero.Name].Value);
            tiposDeDocumento.TryGetValue(dgvRecepciones.CurrentRow.Cells[colRecepcionTipoDocumento.Name].Value.ToString(), out tipoDocumentoSeleccionado);

            frmDocumentoRecepcion f = new frmDocumentoRecepcion();

            f.Mostrar(new Documento(codigoAlmacenDocumentoSeleccionado, tipoDocumentoSeleccionado, numeroDocumentoSeleccionado));
        }

        private void dtpFechaDesde_Leave(object sender, EventArgs e)
        {
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddDays(1);
        }
    }
}
