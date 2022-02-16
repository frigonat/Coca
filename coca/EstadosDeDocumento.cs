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
	public enum EstadosDeDocumento : int
    {
		/// <summary>
		/// Documento pendiente de procesar.-
		/// </summary>
		Pendiente = 0,

		/// <summary>
		/// Documento en proceso.-
		/// </summary>
		EnProceso= 1,

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