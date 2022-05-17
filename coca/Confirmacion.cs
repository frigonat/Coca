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
    public class Confirmacion
    {
        #region atributos

        /// <summary>
        /// Número del documento.-
        /// </summary>
        private long numero;

        /// <summary>
        /// Tipo del documento.-
        /// </summary>
        private TipoDeDocumento tipo;

        /// <summary>
        /// Almacén al que pertenece la confirmación.-
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
        /// Estado de la confirmación.-
        /// </summary>
        private EstadosDeDocumento estado;

        /// <summary>
        /// Código de Evento para la confirmación.-
        /// </summary>
        private string evento;

        /// <summary>
        /// Fecha y hora en la que se generó la confirmación.-
        /// </summary>
        private DateTime fechaHoraDeAlta;

        /// <summary>
        /// Nombre del usuario que generó la confirmación.-
        /// </summary>
        private string usuarioDeAlta;

        /// <summary>
        /// Nombre del archivo de transmisión.-
        /// </summary>
        private string nombreArchivoDeTransmision;

        /// <summary>
        /// Fecha y hora en la que se realizó el proceso de la confirmación.-
        /// </summary>
        private DateTime fechaHoraDeProceso;

        /// <summary>
        /// Nombre del usuario que realizó el proceso de la confirmación.-
        /// </summary>
        private string usuarioDeProceso;

        /// <summary>
        /// Cantidad de pallets existentes en la confirmación.-
        /// </summary>
        private int cantidadDePallets;

        /// <summary>
        /// Cantidad de cajas existentes en la confirmación.-
        /// </summary>
        private int cantidadDeCajas;

        /// <summary>
        /// Cantidad de unidades existentes en la confirmación.-
        /// </summary>
        private int cantidadDeUnidades;

        /// <summary>
        /// Lista de Pallets del documento.-
        /// </summary>
        private List<Pallet> pallets;

        /// <summary>
        /// Lista de Cajas de la confirmación.-
        /// </summary>
        private List<Caja> cajas;

        /// <summary>
        /// Lista de Unidades de la confirmación.-
        /// </summary>
        private List<Unidad> unidades;

        /// <summary>
        /// Número del CNPJ de origen en el sobre SOAP.-
        /// </summary>
        private string cnpjSOAP_Sender;

        /// <summary>
        /// Número del CNPJ de destino en el sobre SOAP.-
        /// </summary>
        private string cnpjSOAP_Receiver;

        /// <summary>
        /// Número de CNPJ de Partner.-
        /// </summary>
        private string cnpjPartner;

        /// <summary>
        /// Número de CNPJ del Transportista, según ANVISA.-
        /// </summary>
        private string cnpjTransporte;

        /// <summary>
        /// Número de CNPJ del Declarante, según ANVISA.-
        /// </summary>
        private string cnpjDeclarante;

        /// <summary>
        /// Identificador de Notificaciones de Eventos.-
        /// </summary>
        private string evtNotifId;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el número del documento.-
        /// </summary>
        public long Numero
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
        /// Obtiene el CNPJ del almacén.-
        /// </summary>
        public string CNPJ_Almacen
        {
            get { return this.almacen.CNPJ; }
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

        /// <summary>
        /// Obtiene el Estado del documento.-
        /// </summary>
        public EstadosDeDocumento Estado
        {
            get { return this.estado; }
        }

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

        /// <summary>
        /// Obtiene el número del CNPJ de origen en el sobre SOAP.-
        /// </summary>
        public string CnpjSOAP_Sender
        {
            get { return this.cnpjSOAP_Sender; } 
        }

        /// <summary>
        /// Obtiene el número del CNPJ de destino en el sobre SOAP.-
        /// </summary>
        public string CnpjSOAP_Receiver
        {
            get { return this.cnpjSOAP_Receiver; }
        }

        /// <summary>
        /// Obtiene el CNPJ del partner.-
        /// </summary>
        public string CnpjPartner
        { 
            get { return this.cnpjPartner; }
        }

        /// <summary>
        /// Obtiene el CNPJ del Transportista, según ANVISA.
        /// </summary>
        public string CnpjTransporte
        {
            get { return this.cnpjTransporte; }
        }

        /// <summary>
        /// Obtiene el CNPJ del Declarante, según ANVISA.
        /// </summary>
        public string CnpjDeclarante
        {
            get { return this.cnpjDeclarante; }
        }

        /// <summary>
        /// Obtiene el Identificador de Notificaciones de Eventos.-
        /// </summary>
        public string EvtNotifId
        {
            get { return this.evtNotifId; }
        }

#endregion

        /// <summary>
        /// Nombre de la bitácora de datos comunes.-
        /// </summary>
        private const string nombreBitacora = "coca";

        /// <summary>
        /// Nombre del objeto de negocios.-
        /// </summary>
        private const string objetoDeNegocio = "Confirmacion";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoAlmacenBuscado"></param>
        /// <param name="tipoDocumentoBuscado"></param>
        /// <param name="numeroDocumentoBuscado"></param>
        /// <exception cref="Exception"></exception>
        /// <exception cref="TipoDeDocumentoNoValidoException"></exception>
        /// <exception cref="DocumentoNoValidoException"></exception>
        /// <exception cref="DocumentoNoEncontradoException"></exception>
        public Confirmacion(string codigoAlmacenBuscado, string tipoDocumentoBuscado, long numeroConfirmacionBuscada)
        {
            string iSQL = "";
            string mensaje = "";
            DataTable confirmacionBuscada;
            iSeriesConnection cn;
            List<string> parametrosDeConexion = new List<string>();
            Almacen almacen = null;
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
                catch (Exception)
                {
                    //
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


            //Valida que el Número de Confirmación sea válido.-
            if (numeroConfirmacionBuscada == 0)
                throw new Exception("El número de confirmación no es válido.");

            iSQL = "SELECT * FROM BOSS06FLT.SER002A0 ";
            iSQL += "WHERE ALMACEN = '" + almacen.Codigo + "' AND ";
            iSQL += "TIPO_DOCUMENTO = '" + tipoDocumentoBuscado + "' AND ";
            iSQL += "ID_DOCUMENTO = " + numeroConfirmacionBuscada.ToString();

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
                confirmacionBuscada = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido instanciar la confirmación con los datos recibidos. Mensajes posteriores pueden contener mayor información.-";
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

            if (confirmacionBuscada.Rows.Count != 0)
            {
                object ax;

                this.numero = numeroConfirmacionBuscada;
                this.tipo = td;
                this.almacen = almacen;
                this.numeroDocumentoDeEntrada = confirmacionBuscada.Rows[0].Field<string>("NRO_DOC_RECEPCION").Trim();
                this.numeroNotaFiscal = confirmacionBuscada.Rows[0].Field<string>("NOTA_FISCAL").Trim();
                this.evento = confirmacionBuscada.Rows[0].Field<string>("NRO_PROCESO");
                this.fechaHoraDeAlta = confirmacionBuscada.Rows[0].Field<DateTime>("FECHA_ALTA");
                this.usuarioDeAlta = confirmacionBuscada.Rows[0].Field<string>("USUARIO_ALTA");
                this.nombreArchivoDeTransmision = confirmacionBuscada.Rows[0].Field<string>("ARCHIVO_PROCESO");
                this.fechaHoraDeProceso = confirmacionBuscada.Rows[0].Field<DateTime>("FECHA_PROCESO");
                this.usuarioDeProceso = confirmacionBuscada.Rows[0].Field<string>("USUARIO_PROCESO");
                this.cantidadDePallets = confirmacionBuscada.Rows[0].Field<int>("CANTIDAD_PALLETS"); 
                this.cantidadDeCajas = confirmacionBuscada.Rows[0].Field<int>("CANTIDAD_CAJAS");
                this.cantidadDeUnidades = 0;
                this.cnpjSOAP_Sender = confirmacionBuscada.Rows[0].Field<string>("PARTNER_FROM");
                this.cnpjSOAP_Receiver = confirmacionBuscada.Rows[0].Field<string>("PARTNER_TO");
                this.evtNotifId = confirmacionBuscada.Rows[0].Field<string>("ID_NOTIFICACIONES_EVENTOS");

                EstadosDeDocumento estadoActual;
                if (Enum.TryParse(confirmacionBuscada.Rows[0].Field<string>("ESTADO").ToString(), out estadoActual))
                {
                    if (Enum.IsDefined(typeof(EstadosDeDocumento), estadoActual))
                    {
                        this.estado = estadoActual;
                    }
                    else
                    {
                        mensaje = "No se puede determinar el estado de la confirmación " + this.Numero.ToString();
                        Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                        throw new DocumentoNoValidoException(mensaje);
                    }
                }

                try
                {
                    cn.Open();

                    iSQL = "SELECT * FROM BOSS06FLT.SER002F1 WHERE trim(CCIDDOC) = '" + numeroConfirmacionBuscada.ToString() + "' FETCH FIRST ROW ONLY";
                    confirmacionBuscada = cn.ExecuteQuery(iSQL);
                    this.cnpjDeclarante = confirmacionBuscada.Rows[0].Field<object>("CCCNPJC").ToString();
                    this.cnpjPartner = confirmacionBuscada.Rows[0].Field<object>("CCGS1").ToString();
                    this.cnpjTransporte = confirmacionBuscada.Rows[0].Field<object>("CCCNPJT").ToString();

                    iSQL = "SELECT count(*) FROM BOSS06FLT.SER002F2 WHERE trim(JJIDDOC) = '" + numeroConfirmacionBuscada.ToString() + "'";
                    ax = cn.ExecuteScalar(iSQL);
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
                mensaje = "No se ha encontrado una confirmación con los datos especificados (" + ")";
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
        public static List<Confirmacion> Obtener(DateTime fechaDesde, DateTime fechaHasta)
        {
            string iSQL = "";

            iSQL = "SELECT * FROM BOSS06FLT.SER002A0 ";
            iSQL += "WHERE FECHA_ALTA BETWEEN '";
            iSQL += fechaDesde.ToString("yyyy-MM-dd") + "' AND '" + fechaHasta.ToString("yyyy-MM-dd") + "' ORDER BY 1";
            return obtener(iSQL);
        }
            
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <param name="numeroLote"></param>
        /// <returns></returns>
        public static List<Confirmacion> Obtener(DateTime fechaDesde, DateTime fechaHasta, string numeroLote)
        {
            string iSQL = "";

            iSQL = "SELECT ID, JJLOTE, ALMACEN, TIPO_DOCUMENTO ";
            iSQL += "FROM BOSS06FLT.SER002A0 ";
            iSQL += "LEFT JOIN BOSS06FLT.SER002F2 ON ID = JJIDDOC ";
            iSQL += "WHERE FECHA_ALTA BETWEEN '" + fechaDesde.ToString("yyyy-MM-dd") + "' AND '" + fechaHasta.ToString("yyyy-MM-dd") + "'";
            iSQL += "AND trim(JJLOTE) = '" + numeroLote + "' ";
            iSQL += "GROUP BY ID, JJLOTE, ALMACEN, TIPO_DOCUMENTO ";
            iSQL += "ORDER BY 1";

            return obtener(iSQL);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iSQL"></param>
        /// <returns></returns>
        private static List<Confirmacion> obtener(string iSQL)
        {
            List<Confirmacion> listaParaDevolver = new List<Confirmacion>();
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
                registrosEncontrados = cn.ExecuteQuery(iSQL, 0);
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
                            decimal a25 = fila.Field<decimal>("ID");
                            long a = System.Convert.ToInt32(a25);
                            Confirmacion nuevaConfirmacion = new Confirmacion(fila.Field<string>("ALMACEN"), fila.Field<string>("TIPO_DOCUMENTO"), a);
                            listaParaDevolver.Add(nuevaConfirmacion);
                        }
                        catch (Exception ex)
                        {
                            //do nothing
                        }
                    }
                }
            }

            return listaParaDevolver;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Pallet> ObtenerPallets()
        {
            recuperarPallets();
            return this.pallets;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void recuperarPallets()
        {
            string iSQL = "";
            string mensaje = "";
            DataTable palletsEncontrados;
            iSeriesConnection cn;
            List<string> listaParaDevolver = new List<string>();
            List<string> parametrosDeConexion = new List<string>();

            this.pallets = new List<Pallet>();

            iSQL = "SELECT DISTINCT (ccpal), cciddoc FROM BOSS06FLT.SER002F1 WHERE CCIDDOC = " + this.Numero.ToString();

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
                palletsEncontrados = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se han podido obtener los pallets de la confirmación. Mensajes posteriores pueden contener mayor información.-";
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

            foreach (DataRow fila in palletsEncontrados.Rows)
            {
                this.pallets.Add(new Pallet(fila.Field<string>("CCPAL"), this.Numero, false));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void recuperarCajas()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerLotes()
        {
            List<string> listaParaDevolver = new List<string>();
            List<string> parametrosDeConexion = new List<string>();
            iSeriesConnection cn;
            DataTable registrosEncontrados = null;

            string iSQL = "SELECT DISTINCT(JJLOTE) FROM BOSS06FLT.SER002F2 WHERE JJIDDOC = " + this.Numero.ToString();

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
                Bitacora.AgregarEntrada("Han aparecido errores al intentar obtener los lotes de la confirmación actual. Puede haber excepciones internas con mayor detalle.-", TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
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
                    listaParaDevolver.Add(fila.Field<string>("JJLOTE"));
            }

            return listaParaDevolver;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerUnidades()
        {
            List<string> listaParaDevolver = new List<string>();
            List<string> parametrosDeConexion = new List<string>();
            iSeriesConnection cn;
            DataTable registrosEncontrados = null;

            string iSQL = "SELECT DISTINCT(JJSKU) FROM BOSS06FLT.SER002F2 WHERE JJIDDOC = " + this.Numero.ToString();

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
                Bitacora.AgregarEntrada("Han aparecido errores al intentar obtener los lotes del archivo documento actual. Puede haber excepciones internas con mayor detalle.-", TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
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
                    listaParaDevolver.Add(fila.Field<string>("JJSKU"));
            }

            return listaParaDevolver;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssccPallet"></param>
        /// <returns></returns>
        public List<string> ObtenerCajas(string ssccPallet)
        {
            List<string> listaParaDevolver = new List<string>();
            List<string> parametrosDeConexion = new List<string>();
            iSeriesConnection cn;
            DataTable registrosEncontrados = null;

            string iSQL = "SELECT cccx FROM BOSS06FLT.SER002F1 WHERE CCIDDOC = " + this.Numero.ToString() + " AND CCPAL = '" + ssccPallet.Trim() + "'";

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
                Bitacora.AgregarEntrada("Han aparecido errores al intentar obtener las cajas del pallet " + ssccPallet + ". Puede haber excepciones internas con mayor detalle.-", TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
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
                    listaParaDevolver.Add(fila.Field<string>("cccx"));
            }

            return listaParaDevolver;

        }
    }
}

