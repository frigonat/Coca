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
    public partial class frmPrincipal : Form
    {
        List<string> parametrosDeConexion;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //barra de estado
            tslConexion_iSeries.Text = "No hay conexión a base de datos";

        }

        private void tslConexion_iSeries_Click(object sender, EventArgs e)
        {
            
            try
            {
                frmLogin_iSeries f = new frmLogin_iSeries();

                if (f.Mostrar() == DialogResult.OK)
                {
                    parametrosDeConexion = iSeries.ObtenerCredenciales();
                    tslConexion_iSeries.Text = "Conectado a base de datos " + parametrosDeConexion[0];
                }
                else
                {
                    tslConexion_iSeries.Text = "No hay conexión a base de datos";
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }



        /***********************/

        /// <summary>
        /// Recorre la lista de formularios abiertos en busca del formulario solicitados; si lo encuentra, lo activa y sino, lo abre.-
        /// </summary>
        /// <param name="formularioParaAbrir"></param>
        private void mostrarFormulario(Form formularioParaAbrir)
        {
            bool formularioEncontrado = false;
            Form g = null;

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == formularioParaAbrir.Name)
                {
                    formularioEncontrado = true;
                    g = f;
                }
            }

            if (formularioEncontrado)
            {
                g.Activate();
            }
            else
            {
                formularioParaAbrir.MdiParent = this;
                formularioParaAbrir.Show();
            }
        }

        private void recepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecepciones f = new frmRecepciones();
            mostrarFormulario(f);
        }
    }
}
