using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinidad.Auditoria;

namespace coca
{
    public partial class frmConexionDb2 : Form
    {
        iSeriesConnection cn;
        List<string> parametrosDeConexion = new List<string>();

        public frmConexionDb2()
        {
            InitializeComponent();
        }

        private void frmConexionDb2_Load(object sender, EventArgs e)
        {
            string mensaje;

            try
            {
                parametrosDeConexion = iSeries.ObtenerCredenciales();
            }
            catch (Exception ex)
            {
                parametrosDeConexion = null;
                throw ex;
            }

            try
            {
                cn = new iSeriesConnection(parametrosDeConexion[0], parametrosDeConexion[1], parametrosDeConexion[2]);
                cn.Open();
                
                string cadena = cn.ConnectionString;

                txtDatosConexion.Text = "Conectado a la base de datos " + cn.DataBase +  Environment.NewLine;
                txtDatosConexion.Text += "=======================================" + Environment.NewLine;
                txtDatosConexion.Text += "Versión: " + cn.ServerVersion + Environment.NewLine;
                txtDatosConexion.Text += "Nombre del sistema: " + cn.SystemName + " (" + cn.SystemIP + ") " + Environment.NewLine;
                txtDatosConexion.Text += "Trabajo: " + cn.JobName + Environment.NewLine;
                txtDatosConexion.Text += "=======================================" + Environment.NewLine + Environment.NewLine;
                txtDatosConexion.Text += "Ultima sentencia ejecutada: " + cn.LastExecuted + Environment.NewLine;
                txtDatosConexion.Text += "Registros afectados: " + cn.RowsAffected + Environment.NewLine;
                txtDatosConexion.Text += cn.ExecutionTime + " (ms)" + Environment.NewLine + Environment.NewLine;

                #region nuevaCadenaConexion
                string usuario;
                string relleno;
                string pwd;
                int largo = 0;
                int x = 0;
                string nuevaCadenaConexion;
                string[] componentes = cn.ConnectionString.Split(';');
                x = componentes[2].IndexOf("=");
                usuario = componentes[2].Substring(0, x + 1);
                pwd = componentes[2].Substring(x + 1);
                largo = pwd.Length;

                relleno = "*";
                for (int i = 0; i < largo; i++)
                    relleno += "*";

                nuevaCadenaConexion = componentes[0] + ";" + componentes[1] + ";" + usuario + relleno + ";" + componentes[3];
                txtDatosConexion.Text += nuevaCadenaConexion;
                #endregion

                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido instanciar el documento con los datos recibidos. Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, "frmConexionDb2", 0, "coca");

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    mensaje = excepcionActual.Message;
                    Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, "frmConexionDb2", 0, "coca");
                    excepcionActual = excepcionActual.InnerException;
                }

                //Se arroja la excepción para que la procese el método llamador.-
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDatosConexion.Text);
            MessageBox.Show("Info copiada al portapapeles!!", "Coca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
