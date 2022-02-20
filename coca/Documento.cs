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
        /// Tipo del documento.-
        /// </summary>
        private TipoDeDocumento tipo;

        /// <summary>
        /// Almacén al que pertenece el documento.-
        /// </summary>
        private Almacen almacen;

        /// <summary>
        /// Número del documento de entrada que ampara el documento.-
        /// </summary>
        private string numeroDocumentoDeEntrada;

        /// <summary>
        /// Número de la nota fiscal que ampara el documento.-
        /// </summary>
        private string numeroNotaFiscal;

        /// <summary>
        /// Estado del documento.-
        /// </summary>
        private EstadosDeDocumento estado;

        /// <summary>
        /// Código de Evento para el documento.-
        /// </summary>
        private string evento;

        /// <summary>
        /// Fecha y hora en la que se realizó el alta del documento.-
        /// </summary>
        private DateTime fechaHoraDeAlta;

        /// <summary>
        /// Nombre del usuario de alta del documento.-
        /// </summary>
        private string usuarioDeAlta;

        /// <summary>
        /// Nombre del archivo de transmisión.-
        /// </summary>
        private string nombreArchivoDeTransmision;

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

        /// <summary>
        /// Cantidad de pallets existentes en el documento de recepción.-
        /// </summary>
        private int cantidadDePallets;

        /// <summary>
        /// Cantidad de cajas existentes en el documento de recepción.-
        /// </summary>
        private int cantidadDeCajas;

        /// <summary>
        /// Cantidad de unidades existentes en el documento de recepción.-
        /// </summary>
        private int cantidadDeUnidades;

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
        /// Obtiene el tipo de documento.-
        /// </summary>
        public TipoDeDocumento Tipo 
        { 
            get { return this.tipo; } 
            
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
        public string NumeroDocumentoDeEntrada
        {
            get { return this.numeroDocumentoDeEntrada; }
        }

        /// <summary>
        /// Obtiene el número de nota fiscal del documento.-
        /// </summary>
        public string NumeroNotaFiscal
        {
            get { return this.numeroNotaFiscal; }
        }

        //estado

        /// <summary>
        /// Obtiene el código de Evento para el documento.-
        /// </summary>
        /// <returns></returns>
        public string Evento
        {
            get { return this.evento; }
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
        /// Nombre del archivo de transmisión.-
        /// </summary>
        public string NombreArchivoDeTransmision
        {
            get { return this.nombreArchivoDeTransmision; }
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

        /// <summary>
        /// Obtiene la cantidad de pallets del documento.-
        /// </summary>
        public int CantidadDePallets
        {
            get { return this.cantidadDePallets; }
        }

        /// <summary>
        /// Obtiene la cantidad de cajas del documento.-
        /// </summary>
        public int CantidadDeCajas 
        {
            get { return this.cantidadDeCajas; }
        }

        /// <summary>
        /// Obtiene la cantidad de unidades del documento.-
        /// </summary>
        public int CantidadDeUnidades
        {
            get { return this.cantidadDeUnidades; }
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
            TipoDeDocumento td;

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

            try
            {
                td = new TipoDeDocumento(tipoDocumentoBuscado);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            //Valida que el Número de Documento sea válido.-
            if (numeroDocumentoBuscado == 0)
                throw new Exception("El número de documento no es válido.");

            iSQL = "SELECT * FROM BOSS06FLT.SER001A0 ";
            iSQL += "WHERE ALMACEN = '" + almacen.Codigo + "' AND ";
            iSQL += "TIPO_DOCUMENTO = '" + tipoDocumentoBuscado + "' AND ";
            iSQL += "ID_DOCUMENTO = " + numeroDocumentoBuscado.ToString();

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
                object ax;
                DataTable palletsEncontrado;

                // VARCHAR_FORMAT(timestamp_recepcion ,'yyyy-mm-dd')
                this.numero = numeroDocumentoBuscado;
                this.tipo = td;
                this.almacen = almacen;
                this.numeroDocumentoDeEntrada = documentoBuscado.Rows[0].Field<string>("NRO_DOC_RECEPCION").Trim();
                this.numeroNotaFiscal = documentoBuscado.Rows[0].Field<string>("NOTA_FISCAL").Trim();
                this.fechaHoraDeAlta = documentoBuscado.Rows[0].Field<DateTime>("TIMESTAMP_RECEPCION");
                this.usuarioDeAlta = documentoBuscado.Rows[0].Field<string>("USUARIO_RECEPCION");
                this.usuarioDeProceso = documentoBuscado.Rows[0].Field<string>("USUARIO_PROCESO");
                this.fechaHoraDeProceso = documentoBuscado.Rows[0].Field<DateTime>("FECHA_PROCESO");
                this.pantallaDeProceso = "*Ninguna";
                this.evento = documentoBuscado.Rows[0].Field<string>("NRO_PROCESO");
                this.nombreArchivoDeTransmision = documentoBuscado.Rows[0].Field<string>("ARCHIVO");   

                try
                {
                    cn.Open();

                    iSQL = "SELECT DISTINCT (ttpal) FROM BOSS06FLT.SER001F1 WHERE TTIDDOC = " + numeroDocumentoBuscado;
                    palletsEncontrado = cn.ExecuteQuery(iSQL);
                    this.cantidadDePallets = palletsEncontrado.Rows.Count;

                    iSQL = "SELECT COUNT(ttcx) FROM BOSS06FLT.SER001F1 WHERE TTIDDOC = " + numeroDocumentoBuscado;
                    ax = cn.ExecuteScalar(iSQL);
                    if (ax is DBNull)
                        this.cantidadDeCajas= 0;
                    else
                        this.cantidadDeCajas = System.Convert.ToInt32(ax);

                    iSQL = "SELECT COUNT(*) FROM BOSS06FLT.SER001F2 WHERE GGIDDOC = " + numeroDocumentoBuscado;
                    ax = cn.ExecuteScalar(iSQL);
                    if (ax is DBNull)
                        this.cantidadDeUnidades = 0;
                    else
                        this.cantidadDeUnidades = System.Convert.ToInt32(ax);

                    cn.Close();

                }
                catch (Exception)
                {

                    throw;
                }
                    
            }
            else
            {
                mensaje = "No se ha encontrado un documento con los datos especificados (" + ")";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Notificacion, objetoDeNegocio, 0, nombreBitacora);
                throw new DocumentoNoEncontradoException(mensaje);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public static List<Documento> Obtener(DateTime fechaDesde, DateTime fechaHasta)
        {
            string iSQL = "";

            iSQL = "SELECT * FROM BOSS06FLT.SER001A0 ";
            iSQL += "WHERE VARCHAR_FORMAT(timestamp_recepcion ,'yyyy-mm-dd') BETWEEN '";
            iSQL += fechaDesde.ToString("yyyy-MM-dd") + "' AND '" + fechaHasta.ToString("yyyy-MM-dd") + "' ORDER BY 1";
            return obtener(iSQL);
        }
            
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iSQL"></param>
        /// <returns></returns>
        private static List<Documento> obtener(string iSQL)
        {
            List<Documento> listaParaDevolver = new List<Documento>();
            List<string> parametrosDeConexion = new List<string>();
            iSeriesConnection cn;
            DataTable registrosEncontrados = null;

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
                registrosEncontrados = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                Bitacora.AgregarEntrada("Han aparecido errores al intentar obtener los registros solicitados. Puede haber excepciones internas con mayor detalle.-", TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                Bitacora.AgregarEntrada("iSQL ejecutada: " + iSQL, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    Bitacora.AgregarEntrada(excepcionActual.Message, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                    excepcionActual = ex.InnerException;
                }
            }

            if (registrosEncontrados != null)
            {
                foreach (DataRow fila in registrosEncontrados.Rows)
                {
                    if (fila.Field<object>("ALMACEN") is System.DBNull)
                    {
                        //
                    }
                    else
                    {
                        try
                        {
                            int a = fila.Field<int>("ID");
                            Documento nuevoDocumento = new Documento(fila.Field<string>("ALMACEN"), fila.Field<string>("TIPO_DOCUMENTO"), fila.Field<int>("ID"));
                            listaParaDevolver.Add(nuevoDocumento);
                        }
                        catch (Exception)
                        {
                            //do nothing
                        }
                    }
                }
            }

            return listaParaDevolver;
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
