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
        /// Nombre del almacén.-
        /// </summary>
        private string nombre;

        /// <summary>
        /// CNPJ del almacén.-
        /// </summary>
        private string cnpj;

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

        /// <summary>
        /// Obtiene el CNPJ del almacén.-
        /// </summary>
        public string CNPJ
        {
            get { return this.cnpj; }   
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

            if (almacenBuscado.Rows.Count == 0)
            {
                this.codigo = codigoBuscado;
                this.nombre = "Almacén no encontrado";
                this.cnpj = "*Desconocido";
            }
            else
            {
                this.codigo = almacenBuscado.Rows[0].Field<string>("WHWHS");
                this.nombre = almacenBuscado.Rows[0].Field<string>("WHDESC");
                this.cnpj = "999999999999";
            }
        }

        /// <summary>
        /// Obtiene una lista con todos los almacenes existentes en el sistema.-
        /// </summary>
        /// <returns></returns>
        public static List<Almacen> Obtener()
        {
            List<Almacen> listaParaDevolver = new List<Almacen>();
            List<string> parametrosDeConexion = new List<string>();
            iSeriesConnection cn;
            DataTable registrosEncontrados = null;

            string iSQL = "";
            iSQL = "SELECT * FROM PSIWBFL62.WWHSB ORDER BY WHDESC";

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
                    try
                    {
                        Almacen nuevoAlmacen = new Almacen(fila.Field<string>("WHWHS"));
                        listaParaDevolver.Add(nuevoAlmacen);
                    }
                    catch (Exception)
                    {
                        //do nothing
                    }
                }
            }

            return listaParaDevolver;
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
