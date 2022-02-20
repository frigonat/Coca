using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coca
{
    public partial class frmRecepciones : Form
    {
        public frmRecepciones()
        {
            InitializeComponent();
        }

        private void frmRecepciones_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-2);
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddDays(+1);

            Dictionary<string, string> tiposDeDocumento = new Dictionary<string, string>();
            tiposDeDocumento = TipoDeDocumento.Obtener();

            cmbTiposDeDocumento.Items.Add("*Todos");
            cmbClientes.Items.Add("*Todos");

            foreach (KeyValuePair<string, string> kvp in tiposDeDocumento)
                cmbTiposDeDocumento.Items.Add(kvp.Value);

            cmbClientes.SelectedIndex = 0;
            cmbTiposDeDocumento.SelectedIndex = 0;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            List<Documento> documentos = Documento.Obtener(dtpFechaDesde.Value, dtpFechaHasta.Value);


            dgvRecepciones.Rows.Clear();

            object[] valores = new object[12];

            foreach (Documento d in documentos)
            {
                valores[0] = d.CodigoDeAlmacen;
                valores[1] = d.NombreDeAlmacen;
                valores[2] = d.Tipo.Descripcion;
                valores[3] = d.Numero.ToString();
                valores[4] = d.NumeroDocumentoDeEntrada.ToString();
                valores[5] = d.NumeroNotaFiscal.ToString();
                valores[6] = d.FechaHoraDeAlta.ToString("dd-MM-yyyy");
                valores[7] = d.FechaHoraDeAlta.ToString("HH.mm.ss");
                valores[8] = d.NombreArchivoDeTransmision;
                valores[9] = d.CantidadDePallets;
                valores[10] = d.CantidadDeCajas;
                valores[11] = d.CantidadDeUnidades;
                dgvRecepciones.Rows.Add(valores);
            }

            tslCantidadDeRecepciones.Text = dgvRecepciones.Rows.Count.ToString();
        }
    }
}
