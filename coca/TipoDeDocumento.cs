using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coca
{
    public class TipoDeDocumento
    {
        #region atributos

        /// <summary>
        /// Tipo de Documento.-
        /// </summary>
        private string codigo;
        
        /// <summary>
        /// `Descripción del tipo de documento.-
        /// </summary>
        private string descripcion;

        #endregion


        #region propiedades

        /// <summary>
        /// Obtiene el código del tipo de documento.-
        /// </summary>
        public string Codigo
        {
            get { return this.codigo; } 
        }

        /// <summary>
        /// Obtiene la descripción del tipo de documento.-
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion;} 
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoBuscado"></param>
        /// <exception cref="TipoDeDocumentoNoEncontradoException"></exception>
        public TipoDeDocumento(string codigoBuscado)
        {
            bool tipoEncontrado = false;

            if (codigoBuscado == "I")
            {
                this.codigo = codigoBuscado;
                this.descripcion = "Ingreso de Mercadería";
                tipoEncontrado = true;
            }

            if (codigoBuscado == "P")
            {
                this.codigo = codigoBuscado;
                this.descripcion = "Pedido de Venta";
                tipoEncontrado = true;
            }

            if (codigoBuscado == "F")
            {
                this.codigo = codigoBuscado;
                this.descripcion = "Finalización";
                tipoEncontrado = true;
            }

            if (codigoBuscado == "R")
            {
                this.codigo = codigoBuscado;
                this.descripcion = "Recepción";
                tipoEncontrado = true;
            }

            if (codigoBuscado == "D")
            {
                this.codigo = codigoBuscado;
                this.descripcion = "Devolución";
                tipoEncontrado = true;
            }

            if (!tipoEncontrado)
                throw new TipoDeDocumentoNoEncontradoException("No se ha encontrado un tipo de documento para el còdigo recibido [" + codigoBuscado + "].");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> Obtener()
        {
            Dictionary<string, string> listaParaDevolver = new Dictionary<string, string>();

            TipoDeDocumento td;

            td = new TipoDeDocumento("I");
            listaParaDevolver.Add(td.Codigo, td.Descripcion);

            td = new TipoDeDocumento("P");
            listaParaDevolver.Add(td.Codigo, td.Descripcion);

            td = new TipoDeDocumento("R");
            listaParaDevolver.Add(td.Codigo, td.Descripcion);

            td = new TipoDeDocumento("D");
            listaParaDevolver.Add(td.Codigo, td.Descripcion);

            td = new TipoDeDocumento("F");
            listaParaDevolver.Add(td.Codigo, td.Descripcion);

            return listaParaDevolver;
        }

    }
}
