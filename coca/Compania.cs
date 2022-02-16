using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinidad.Auditoria;

namespace coca
{
    public class Compania
    {

        #region atributos

        /// <summary>
        /// Código de la compañía.-
        /// </summary>
        private string codigo;


        /// <summary>
        /// Nombre de la compañía.-
        /// </summary>
        private string nombre;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el código de la compañía.-
        /// </summary>
        public string Codigo
        {
            get { return this.codigo; }
        }

        /// <summary>
        /// Obtiene el nombre de la compañía.-
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
        private const string objetoDeNegocio = "Compañía";

        /// <summary>
        /// Constructor. Obtiene una nueva instancia de la clase, incializándola con los valores de la compañía cuyo código se recibe como parámetro.-
        /// <para>Arroja las siguientes excepciones:</para>
        /// <para>CompaniaNoExistenteException(): si no puede hallarse una compañía con el Id recibido.-</para>
        /// <para>CompaniaNoValidaException(): si la compañía hallada contiene datos no válidos.-</para>
        /// </summary>
        /// <param name="codigoBuscado">Código de la compañía buscada.-</param>
        public Compania(string codigoBuscado)
        {
            string iSQL = "";
            string mensaje = "";
            DataTable companiaBuscada;
            iSeriesConnection cn;
            List<string> parametrosDeConexion = new List<string>();

            //Valida que el codigo recibido sea válido.-
            if (codigoBuscado.Length <= 0)
                throw new CodigoNoValidoException("El código del almacén informado no es válido");

            iSQL = "SELECT * FROM PSIWBFL62.WCOMB WHERE COCOMP = '" + codigoBuscado + "'";

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
                companiaBuscada = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                //Se anotan las excepciones de error en la bitácora.-
                mensaje = "No se ha podido instanciar la compañía con el código " + codigoBuscado.ToString() + ". Mensajes posteriores pueden contener mayor información.-";
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

            if (companiaBuscada.Rows.Count != 0)
            {
                this.codigo = companiaBuscada.Rows[0].Field<string>("COCOMP");
                this.nombre = companiaBuscada.Rows[0].Field<string>("CODESC");
            }
            else
            {
                mensaje = "No se ha encontrado una compañía con el código especificado (" + codigoBuscado.ToString() + ")";
                Bitacora.AgregarEntrada(mensaje, TiposDeEntrada.Notificacion, objetoDeNegocio, 0, nombreBitacora);
                throw new CompaniaNoEncontradaException(mensaje);
            }
        }


        /// <summary>
        /// Obtiene una lista con todas las compañías del sistema.-
        /// </summary>
        /// <returns></returns>
        public static List<Compania> Obtener()
        {
            List<Compania> listaParaDevolver = new List<Compania>();
            DataTable companiasEncontradas = null;
            iSeriesConnection cn;
            string iSQL;
            List<string> parametrosDeConexion = new List<string>();

            iSQL = "SELECT * FROM PSIWBFL62.WCOMB ORDER BY 1";

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
                companiasEncontradas = cn.ExecuteQuery(iSQL);
                cn.Close();
            }
            catch (Exception ex)
            {
                Bitacora.AgregarEntrada("Han aparecido errores al intentar obtener la lista de compañías del sistema. Puede haber excepciones internas con mayor detalle.-", TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);

                Exception excepcionActual = ex;
                while (excepcionActual != null)
                {
                    Bitacora.AgregarEntrada(excepcionActual.Message, TiposDeEntrada.Error, objetoDeNegocio, 0, nombreBitacora);
                    excepcionActual = ex.InnerException;
                }
            }

            if (companiasEncontradas != null)
            {
                foreach (DataRow fila in companiasEncontradas.Rows)
                    listaParaDevolver.Add(new Compania(fila.Field<string>("COCOMP")));     
            }

            return listaParaDevolver;
        }

    }
}
