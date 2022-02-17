using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinidad.Auditoria;

namespace coca
{
    public class Almacen
    {
        #region atributos

        /// <summary>
        /// Código del almacén.-
        /// </summary>
        private string codigo;

        /// <summary>
        /// Nombre del almacén-
        /// </summary>
        private string nombre;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el código del almacén.-
        /// </summary>
        public string Codigo
        {
            get { return this.codigo; }
        }

        /// <summary>
        /// Obtiene el nombre del almacén.-
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }

        }

        #endregion

        /// <summary>
        /// Nombre de la bitácora de datos comunes.-
        /// </summary>
        private const string nombreBitacora = "coca";

        /// <summary>
        /// Nombre del objeto de negocios.-
        /// </summary>
        private const string objetoDeNegocio = "Almacen";

        /// <summary>
        /// Constructor. Devuelve una instancia de la clase valorizada con los datos obtenidos según el parámetro que se recibe. Arroja las siguientes excepciones:
        /// <para>AlmacenNoEncontradoException(): si no puede encontrarse un almacén cuyo código coincida con el especificado.-</para>
        /// <para>AlmacenNoValidoException(): si el almacén encontrado contiene datos no válidos.-</para>
        /// </summary>
        /// <param name="codigoBuscado"></param>
        public Almacen(string codigoBuscado)
        {
            List<string> parametrosDeConexion = new List<string>();
            iSeriesConnection cn;
            DataTable almacenBuscado = null;
            string iSQL;
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

            iSQL = "SELECT * FROM PSIWBFL62.WWHSB WHERE WHWHS = '" + codigoBuscado + "'";

            try
            {
                cn = new iSeriesConnection(parametrosDeConexion[0], parametrosDeConexion[1], parametrosDeConexion[2]);
                cn.Open();
                almacenBuscado = cn.ExecuteQuery(iSQL);
                cn.Close();

            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido instanciar un almacén con el código " + codigoBuscado.ToString() + ". Mensajes posteriores pueden contener mayor información.-";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                Bitacora.AgregarEntrada("iSQL ejecutada: " + iSQL, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    mensaje = excepcionActual.Message;
                    Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                    excepcionActual = excepcionActual.InnerException;
                }
            }
            this.codigo = almacenBuscado.Rows[0].Field<string>("WHWHS");
            this.nombre= almacenBuscado.Rows[0].Field<string>("WHDESC");
        }

        /// <summary>
        /// Obtiene una lista con todos los almacenes existentes en el sistema.-
        /// </summary>
        /// <returns></returns>
        public List<Almacen> Obtener()
        {
            return null;
        }

        /// <summary>
        /// Devuelve una lista con los almacenes cuyo nombre coincida parcialmente con el nombre recibido como parámetro.-
        /// </summary>
        /// <param name="nombreBuscado"></param>
        /// <returns></returns>
        public List<Almacen> Obtener(string nombreBuscado)
        {
            return null;
        }
    }
}
