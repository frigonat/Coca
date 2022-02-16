using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coca
{   
    /// <summary>
    /// Modela una etiqueta agrupadora de Pallet.-
    /// </summary>
    public class Pallet
    {

        #region atributos

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
        /// Crea un nuevo 
        /// </summary>
        /// <param name="nuevoSSCC"></param>
        public Pallet(string nuevoSSCC)
        {
            this.codigoSSCC = nuevoSSCC;
            this.cajas = new List<Caja>();
            this.cantidadCajas = 0;
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
