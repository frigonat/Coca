using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinidad.Auditoria;

namespace coca
{
    public class Caja
    {

        #region atributos

        /// <summary>
        /// Número de documento al que pertence el pallet.-
        /// </summary>
        int numeroDocumento;

        /// <summary>
        /// Código SSCC de la caja.-
        /// </summary>
        private string codigoSSCC;

        /// <summary>
        /// Cantidad de unidades que existen en la caja.-
        /// </summary>
        private int cantidadDeUnidades;

        /// <summary>
        /// Lista de los duis incluídos en la caja
        /// </summary>
        List<Unidad> unidades;
        #endregion

        
        #region propiedades

        /// <summary>
        /// Obtiene el número de documento al que pertence el pallet.-
        /// </summary>
        public int NumeroDocumento
        {
            get { return this.numeroDocumento; }
        }

        /// <summary>
        /// Obtiene el código SSCC de la caja.-
        /// </summary>
        public string CodigoSSCC 
        {
            get { return codigoSSCC; } 
        }
        
        /// <summary>
        /// Cantidad de series que existen en la caja.-
        /// </summary>
        public int CantidadDeUnidades
        {
            get { return cantidadDeUnidades; }
        }


        #endregion


        /// <summary>
        /// Nombre de la bitácora de datos comunes.-
        /// </summary>
        private const string nombreBitacora = "coca";

        /// <summary>
        /// Nombre del objeto de negocios.-
        /// </summary>
        private const string objetoDeNegocio = "Caja";


        /// <summary>
        /// Constructor.-
        /// </summary>
        public Caja(string nuevoSSCC, int nuevoNumeroDeDocumento)
        {
            this.numeroDocumento = nuevoNumeroDeDocumento;
            this.codigoSSCC = nuevoSSCC;
            recuperarCajas();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void recuperarCajas()
        {
            string iSQL;
            string mensaje;

            List<string> parametrosDeConexion = iSeries.ObtenerCredenciales();
            DataTable unidadesEncontradas;
            iSeriesConnection cn;
            this.unidades = new List<Unidad>();

            iSQL = "SELECT GGSERIE, GGGTIN, GGSKU, GGLOTE, GGDTVENC FROM BOSS06FLT.SER001F2 ";
            iSQL += "WHERE GGIDDOC = " + this.NumeroDocumento.ToString() + " ";
            iSQL += "AND trim(GGCX) = '" + this.CodigoSSCC + "'";

            try
            {
                cn = new iSeriesConnection(parametrosDeConexion[0], parametrosDeConexion[1], parametrosDeConexion[2]);
                cn.Open();
                unidadesEncontradas = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se han podido recuperar las unidades de la caja [" + this.CodigoSSCC + "]. Mensajes posteriores pueden contener mayor información.-";
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

            foreach (DataRow fila in unidadesEncontradas.Rows)
            {
                string axSerie = fila.Field<string>("GGSERIE");
                string axGgtin = fila.Field<string>("GGGTIN");
                string axSku = fila.Field<string>("GGSKU");
                string axLote = fila.Field<string>("GGLOTE");
                string axFechaVto = fila.Field<DateTime>("GGDTVENC").ToString("yyyy-MM-dd");
                
                this.unidades.Add(new Unidad(axSerie, axGgtin, axSku, axLote, axFechaVto));
            }

            this.cantidadDeUnidades = 0;

            this.cantidadDeUnidades = unidadesEncontradas.Rows.Count;
        }

        /// <summary>
        /// Agrega un DUI a la lista de la caja.-
        /// </summary>
        public void AgregarUnidad(Unidad nuevaUnidad)
        {
            this.unidades.Add(nuevaUnidad);
            this.cantidadDeUnidades++;
        }


        public List<Unidad> ObtenerUnidades()
        {
            return this.unidades;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoSSCC"></param>
        /// <returns></returns>
        public Unidad ObtenerUnidad(string numeroDeSerie)
        {
            return this.unidades.Find(x => x.NumeroDeSerie == numeroDeSerie);
        }


    }
}
