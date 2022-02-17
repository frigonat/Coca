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
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            List<Documento> documentos = Documento.Obtener(dtpFechaDesde.Value, dtpFechaHasta.Value);


            dgvRecepciones.Rows.Clear();

            object[] valores = new object[10];

            foreach (Documento d in documentos)
            {
                valores[0] = d.CodigoDeAlmacen;
                valores[1] = d.NombreDeAlmacen;
                valores[2] = "";
                valores[3] = d.Numero.ToString();
                valores[4] = d.FechaIngreso.ToString("dd-MM-yyyy");
                valores[5] = d.FechaIngreso.ToString("HH.mm.ss");
                valores[6] = d.UsuarioDeAlta;
                valores[7] = d.CantidadDePallets;
                valores[8] = d.CantidadDeCajas;
                valores[9] = d.CantidadDeUnidades;
                dgvRecepciones.Rows.Add(valores);
                
            }


            tslCantidadDeRecepciones.Text = dgvRecepciones.Rows.Count.ToString();

        }
    }
}
