using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coca
{
    public class Caja
    {

        #region atributos

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
        /// Constructor.-
        /// </summary>
        public Caja(string nuevoSSCC)
        {
            this.codigoSSCC = nuevoSSCC;
            this.unidades = new List<Unidad>();
            this.cantidadDeUnidades = 0;
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
