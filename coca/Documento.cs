using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinidad.Auditoria;

namespace coca
{
    /// <summary>
    /// Modela un documento que se permite consultar mendiante el sistema.-
    /// </summary>
    public class Documento
    {
        #region atributos

        /// <summary>
        /// Número del documento.-
        /// </summary>
        private int numero;

        /// <summary>
        /// Fecha de ingreso del documento.-
        /// </summary>
        private DateTime fechaIngreso;

        /// <summary>
        /// Almacén al que pertenece el documento.-
        /// </summary>
        private Almacen almacen;

        /// <summary>
        /// Número del documento de entrada que ampara el documento.-
        /// </summary>
        private int numeroDocumentoDeEntrada;

        /// <summary>
        /// Número de la nota fiscal que ampara el documento.-
        /// </summary>
        private int numeroNotaFiscal;

        /// <summary>
        /// Estado del documento.-
        /// </summary>
        private EstadosDeDocumento estado;

        /// <summary>
        /// Fecha y hora en la que se realizó el alta del documento.-
        /// </summary>
        private DateTime fechaHoraDeAlta;

        /// <summary>
        /// Nombre del usuario de alta del documento.-
        /// </summary>
        private string usuarioDeAlta;

        /// <summary>
        /// Nombre del dispositivo desde el cual se produjo el alta del documento.-
        /// </summary>
        private string pantallaDeAlta;

        /// <summary>
        /// Fecha y hora en la que se realizó el proceso del documento.-
        /// </summary>
        private DateTime fechaHoraDeProceso;

        /// <summary>
        /// Nombre del usuario que realizó el proceso del documento.-
        /// </summary>
        private string usuarioDeProceso;

        /// <summary>
        /// Obtiene el nombre del dispositivo desde el cual se procesó el documento.-
        /// </summary>
        private string pantallaDeProceso;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el número del documento.-
        /// </summary>
        public int Numero 
        {
            get { return numero; } 
        }

        /// <summary>
        /// Obtiene la fecha de ingreso del documento.-
        /// </summary>
        public DateTime FechaIngreso
        {
            get { return fechaIngreso ; }
        }

        /// <summary>
        /// Obtiene el código de almacén del documento.-
        /// </summary>
        public string CodigoDeAlmacen
        {
            get { return this.almacen.Codigo; }
        }
        
        /// <summary>
        /// Obtiene el nombre del almacén del documento.-
        /// </summary>
        public string NombreDeAlmacen
        {
            get { return this.almacen.Nombre; }
        }

        /// <summary>
        /// Obtiene el número de documento.-
        /// </summary>
        public int NumeroDocumentoDeEntrada
        {
            get { return this.numeroDocumentoDeEntrada; }
        }

        /// <summary>
        /// Obtiene el número de nota fiscal del documento.-
        /// </summary>
        public int NumeroNotaFiscal
        {
            get { return this.numeroNotaFiscal; }
        }

        /// <summary>
        /// Obtiene la fecha y hora en la que se realizó el alta del documento.-
        /// </summary>
        public DateTime FechaHoraDeAlta
        {
            get { return fechaHoraDeAlta; }

        }

        /// <summary>
        /// Obtiene el nombre del usuario que dio de alta del documento.-
        /// </summary>
        public string UsuarioDeAlta
        {
            get { return usuarioDeAlta; }
        }

        /// <summary>
        /// Obtiene el nombre del dispositivo desde el cual se produjo el alta del documento.-
        /// </summary>
        public string PantallaDeAlta
        {
            get { return pantallaDeAlta; }
        }

        /// <summary>
        /// Obtiene la fecha y hora en la que se realizó el proceso del documento.-
        /// </summary>
        public DateTime FechaHoraDeProceso
        {
            get { return fechaHoraDeProceso; }
        }

        /// <summary>
        /// Obtiene el nombre del usuario que realizó el proceso del documento.-
        /// </summary>
        public string UsuarioDeProceso
        {
            get { return usuarioDeProceso; }
        }

        /// <summary>
        /// Obtiene el nombre del dispositivo desde el cual se procesó el documento.-
        /// </summary>
        public string PantallaDeProceso
        {
            get { return pantallaDeProceso; }
        }

        #endregion


        /// <summary>
        /// Nombre de la bitácora de datos comunes.-
        /// </summary>
        private const string nombreBitacora = "coca";

        /// <summary>
        /// Nombre del objeto de negocios.-
        /// </summary>
        private const string objetoDeNegocio = "Documento";

        public Documento(string codigoAlmacenBuscado, string tipoDocumentoBuscado, int numeroDocumentoBuscado)
        {
            string iSQL = "";
            string mensaje = "";
            DataTable documentoBuscado;
            iSeriesConnection cn;
            List<string> parametrosDeConexion = new List<string>();
            Almacen almacen;

            //Valida que el almacén recibido sea válido.-
            if (codigoAlmacenBuscado == "")
            {
                throw new Exception("El código de almacén recibido no es válido.");
            }
            else
            {
                try
                {
                    almacen = new Almacen(codigoAlmacenBuscado);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            //Valida que el Tipo de Documento sea válido.-
            if (tipoDocumentoBuscado == "")
                throw new TipoDeDocumentoNoValidoException("El tipo de documento recibido no válido.");

            //Valida que el Número de Documento sea válido.-
            if (numeroDocumentoBuscado == 0)
                throw new Exception("El número de documento no es válido.");


            iSQL = "SELECT * FROM BOSS06FLT.SER001H1 ";
            iSQL += "WHERE TTWHS = '" + almacen.Codigo + "' AND ";
            iSQL += "WHERE TTTIDO = '" + tipoDocumentoBuscado  + "' AND ";
            iSQL += "WHERE TTIDDOC = " + numeroDocumentoBuscado.ToString() +  ";";

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
                documentoBuscado = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido instanciar el documento con los datos recibidos. Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                Bitacora.AgregarEntrada("iSQL ejecutada: " + iSQL, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    mensaje = excepcionActual.Message;
                    Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                    excepcionActual = excepcionActual.InnerException;
                }

                //Se arroja la excepción para que la procese el método llamador.-
                throw new Exception(ex.Message);
            }

            if (documentoBuscado.Rows.Count != 0)
            {
                this.almacen = almacen;
                this.numero = numeroDocumentoBuscado;
                this.fechaIngreso = DateTime.Now;
                this.numeroNotaFiscal = 0;
                this.numeroDocumentoDeEntrada = 0;
            }
            else
            {
                mensaje = "No se ha encontrado un documento con los datos especificados (" + ")";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Notificacion, objetoDeNegocio, 0, nombreBitacora);
                throw new CompaniaNoEncontradaException(mensaje);
            }
        }
        


        /// <summary>
        /// Lista de Pallets del documento.-
        /// </summary>
        private List<Pallet> pallets;

        /// <summary>
        /// Lista de Cajas del documento.-
        /// </summary>
        private List<Caja> cajas;

        /// <summary>
        /// Lista de Unidades del documento.-
        /// </summary>
        private List<Unidad> unidades;



    }
}
