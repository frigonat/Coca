using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coca
{
    /// <summary>
    /// 
    /// </summary>
    public class Unidad
    {

        #region atributos

        /// <summary>
        /// Numero de serie.-
        /// </summary>
        private string numeroDeSerie;

        /// <summary>
        /// Número de GTIN.-
        /// </summary>
        private string numeroDeGTIN;

        /// <summary>
        /// Código de SKU.-
        /// </summary>
        private string codigoDeSKU;

        /// <summary>
        /// Número de Lote
        /// </summary>
        private string numeroDeLote;

        /// <summary>
        /// Fecha de vencimiento del lote.-
        /// </summary>
        private string fechaDeVencimiento;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el número de serie de la unidad.-
        /// </summary>
        public string NumeroDeSerie 
        {
            get { return numeroDeSerie; } 
        }

        /// <summary>
        /// Obtiene el numero de GTIN de la unidad.-
        /// </summary>
        public string NumeroDeGTIN
        {
            get { return numeroDeGTIN; }
        }

        /// <summary>
        /// </summary>
        /// Obtiene el código de SKU de la unidad.-
        public string CodigoDeSKU
        {
            get { return codigoDeSKU; }
        }

        /// <summary>
        /// Obtiene el número de lote de la unidad.-
        /// </summary>
        public string NumeroDeLote
        {
            get { return numeroDeLote; }
        }

        /// <summary>
        /// Obtiene la fecha de vencimiento del lote al que pertenece la unidad.-
        /// </summary>
        public string FechaDeVencimiento
        {
            get { return fechaDeVencimiento; }
        }

        #endregion


        /// <summary>
        /// Constructor
        /// </summary>
        public Unidad (string nuevoNumeroDeSerie, string nuevoNumeroDeGTIN, string nuevoCodigoDeSKU, string nuevoNumeroDeLote, string nuevaFechaDeVencimiento)
        {
            this.numeroDeSerie = nuevoNumeroDeSerie;
            this.numeroDeGTIN = nuevoNumeroDeGTIN;
            this.codigoDeSKU = nuevoCodigoDeSKU;
            this.numeroDeLote = nuevoNumeroDeLote;
            this.fechaDeVencimiento = nuevaFechaDeVencimiento;
        }

 
    }
}
