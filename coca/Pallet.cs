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
    /// Modela una etiqueta agrupadora de Pallet.-
    /// </summary>
    public class Pallet
    {
        #region atributos

        /// <summary>
        /// Número de documento al que pertence el pallet.-
        /// </summary>
        private long numeroDocumento;

        /// <summary>
        /// Código SSCC del pallet.-
        /// </summary>
        string codigoSSCC;
        
        /// <summary>
        /// Cantidad de cajas del pallet.-
        /// </summary>
        int cantidadCajas;

        /// <summary>
        /// Lista de cajas contenidas en el pallet.-
        /// </summary>
        List<Caja> cajas;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el número de documento al que pertence el pallet.-
        /// </summary>
        public long NumeroDocumento
        {
            get { return this.numeroDocumento; }
        }

        /// <summary>
        /// Obtiene el codigo SSCC del pallet.-
        /// </summary>
        public string CodigoSSCC
        {
            get { return this.codigoSSCC; }
        }

        /// <summary>
        /// Obtiene la cantidad de cajas del pallet.-
        /// </summary>
        public int CantidadCajas
        {
            get { return this.cantidadCajas; }
        }

        #endregion


        /// <summary>
        /// Nombre de la bitácora de datos comunes.-
        /// </summary>
        private const string nombreBitacora = "coca";

        /// <summary>
        /// Nombre del objeto de negocios.-
        /// </summary>
        private const string objetoDeNegocio = "Pallet";

        /// <summary>
        /// Crea un nuevo pallet con el número SSCC recibido y número de documento recibido. Las cajas del mismo (si las hubise) se instancian automáticamente.-
        /// </summary>
        /// <param name="nuevoSSCC">Número de etiqueta SSCC para el pallet.-</param>
        /// <param name="nuevoNumeroDeDocumento">Número de documento al que pertenece el pallet.-</param>
        public Pallet(string nuevoSSCC, long nuevoNumeroDeDocumento)
        {
            this.numeroDocumento = nuevoNumeroDeDocumento;
            this.codigoSSCC = nuevoSSCC;
            RecuperarCajas();
        }

        /// <summary>
        /// Crea un nuevo pallet con el número SSCC recibido y número de documento recibido. Las cajas del mismo se instancian según se indique en el parámetro correspondiente.-
        /// </summary>
        /// <param name="nuevoSSCC">Número de etiqueta SSCC para el pallet.-</param>
        /// <param name="nuevoNumeroDeDocumento">Número de documento al que pertenece el pallet.-</param>
        /// <param name="recuperarCajas">Indica si las cajas del pallet deben recuperarse o no.-</param>
        public Pallet(string nuevoSSCC, long nuevoNumeroDeDocumento, bool recuperarCajas)
        {
            this.numeroDocumento = nuevoNumeroDeDocumento;
            this.codigoSSCC = nuevoSSCC;

            if (recuperarCajas)
                RecuperarCajas();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void RecuperarCajas()
        {
            string iSQL;
            string mensaje;

            List<string> parametrosDeConexion = iSeries.ObtenerCredenciales();
            DataTable cajasEncontradas;
            iSeriesConnection cn;
            this.cajas = new List<Caja>();

            iSQL = "SELECT DISTINCT(cccx) FROM BOSS06FLT.SER002F1 WHERE trim(ccpal) = '" + this.CodigoSSCC + "'";
            try
            {
                cn = new iSeriesConnection(parametrosDeConexion[0], parametrosDeConexion[1], parametrosDeConexion[2]);
                cn.Open();
                cajasEncontradas = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se han podido recuperar las cajas del pallet [" + this.CodigoSSCC + "]. Mensajes posteriores pueden contener mayor información.-";
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
            

            foreach (DataRow fila in cajasEncontradas.Rows)
                this.cajas.Add(new Caja(fila.Field<string>("cccx"), this.NumeroDocumento));

            this.cantidadCajas = cajasEncontradas.Rows.Count;
        }

        /// <summary>
        /// Agrega una caja a la lista del pallet.-
        /// </summary>
        public void AgregarCaja(Caja nuevaCaja)
        {
            this.cajas.Add(nuevaCaja);
            this.cantidadCajas++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nuevoDui"></param>
        /// <param name="SSCC_caja"></param>
        public void AgregarUnidad(Unidad nuevoDui, string SSCC_caja)
        {
            this.cajas.Find(x => x.CodigoSSCC == SSCC_caja).AgregarUnidad(nuevoDui);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoSSCC"></param>
        /// <returns></returns>
        public Caja ObtenerCaja(string codigoSSCC)
        {
            return cajas.Find(x => x.CodigoSSCC == codigoSSCC);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Caja> ObtenerCajas()
        {
            return this.cajas;
        }

    }
}
