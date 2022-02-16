using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace coca
{
    public partial class frmLogin_iSeries : Form
    {
        /// <summary>
        /// Parámetros de conexión al Db2
        /// </summary>
        List<String> parametrosDeConexion;

        string rutaDatos;
        string archivoCredenciales = "ibmi.series";
        string archivoSistemas = "sistemas.dat";
        DialogResult respuesta;

        public DialogResult Mostrar()
        {
            this.ShowDialog();
            return respuesta;
        }

        public frmLogin_iSeries()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                iSeriesConnection cnn = new iSeriesConnection(cmbSistemas.Text, txtUsuario.Text, txtPassword.Text);
                parametrosDeConexion = new List<String>();
                parametrosDeConexion.Add(txtUsuario.Text);
                parametrosDeConexion.Add(txtPassword.Text);
                parametrosDeConexion.Add(cmbSistemas.Text);
                guardarCredenciales();
                respuesta = DialogResult.OK;
                this.Close();
            }
            catch (iDB2Exception ex)
            {
                string mensaje;

                mensaje = ex.Message + Environment.NewLine;
                mensaje += "Código de Error: " + ex.MessageCode.ToString() + Environment.NewLine;
                mensaje += "Descripción: " + ex.MessageDetails;

                respuesta = DialogResult.Cancel;

                MessageBox.Show(mensaje);
            }

            Cursor = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            respuesta = DialogResult.Cancel;
            this.Close();
        }

        private void frmLogin_iSeries_Load(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            rutaDatos = Path.GetDirectoryName(myAssembly.Location);

            cargarSistemasDisponibles();
        }

        /// <summary>
        /// Busca la lista de sistemas disponibles y la carga en el combo para que el usuario elija.-
        /// </summary>
        private void cargarSistemasDisponibles()
        {
            using (StreamReader fr = new StreamReader(rutaDatos + Path.DirectorySeparatorChar + archivoSistemas))
            {
                string renglon;
                while ((renglon = fr.ReadLine()) != null)
                    cmbSistemas.Items.Add(renglon);

                cmbSistemas.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Guarda los datos de conexión ingresados.-
        /// </summary>
        private void guardarCredenciales()
        {
            string renglon;

            StreamWriter sw = new StreamWriter(rutaDatos + Path.DirectorySeparatorChar + archivoCredenciales, false);
            renglon = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(cmbSistemas.Text));
            sw.WriteLine(renglon);
            renglon = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtUsuario.Text));
            sw.WriteLine(renglon);
            renglon = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassword.Text));
            sw.WriteLine(renglon);
            renglon = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(DateTime.Now.ToString("yyyyMMdd HHmmss")));
            sw.WriteLine(renglon);

            sw.Close();
        }
    }
}
