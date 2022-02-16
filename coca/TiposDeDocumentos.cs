using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coca
{
	/// <summary>
	/// Modela los estados de un documento.-
	/// </summary>
	public enum TiposDeDocumento: int
	{
		/// <summary>
		/// Documento pendiente de procesar.-
		/// </summary>
		IngresoDeMercaderia = 0,

		/// <summary>
		/// Documento en proceso.-
		/// </summary>
		PedidoDeVenta = 1,

		/// <summary>
		/// Documento procesado.-
		/// </summary>
		Procesado = 2,

		/// <summary>
		/// Documento anulado.-
		/// </summary>
		Anulado = 5,

		/// <summary>
		/// Documento con errores.-
		/// </summary>
		ConErrores = 8
	}
}