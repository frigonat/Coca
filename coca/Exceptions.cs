using System;
using System.Collections.Generic;
using System.Text;

namespace coca
{
    #region COMPAÑIAS

    /// <summary>
    /// Excepción que se produce cuando se encuentra una compañía con datos no válidos.-
    /// </summary>
    public class CompaniaNoValidaException : Exception
    {
        public CompaniaNoValidaException()
            : base("La compañía tiene datos no válidos.-")
        {
        }

        public CompaniaNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public CompaniaNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se encuentra una compañía.-
    /// </summary>
    public class CompaniaNoEncontradaException : Exception
    {
        public CompaniaNoEncontradaException()
            : base("No se ha podido hallar la compañía buscada.-")
        {
        }

        public CompaniaNoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public CompaniaNoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion

    #region EXCEPCIONES_CREDENCIALES

    /// <summary>
    /// Excepción que se produce cuando se detectan credenciales no válidas.-
    /// </summary>
    public class CredencialesNoValidasException : Exception
    {
        public CredencialesNoValidasException()
            : base("Las credenciales encontradas no son válidas.-")
        {
        }

        public CredencialesNoValidasException(string mensaje)
            : base(mensaje)
        {
        }

        public CredencialesNoValidasException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detectan credenciales que han expirado.-
    /// </summary>
    public class CredencialesExpiradasException : Exception
    {
        public CredencialesExpiradasException()
            : base("Las credenciales han expirado.-")
        {
        }

        public CredencialesExpiradasException(string mensaje)
            : base(mensaje)
        {
        }

        public CredencialesExpiradasException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion

    #region DOCUMENTOS
    /// <summary>
    /// Excepción que se produce cuando se encuentra un documento con datos no válidos.-
    /// </summary>
    public class DocumentoNoValidoException : Exception
    {
        public DocumentoNoValidoException()
            : base("El documento tiene datos no válidos.-")
        {
        }

        public DocumentoNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public DocumentoNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se encuentra un documento.-
    /// </summary>
    public class DocumentoNoEncontradoException : Exception
    {
        public DocumentoNoEncontradoException()
            : base("No se ha podido hallar el documento buscado.-")
        {
        }

        public DocumentoNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public DocumentoNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion

    #region AUDITORIAS

    /// <summary>
    /// Excepción que se produce cuando no se puede crear una auditoría.-
    /// </summary>
    public class AuditoriaNoCreadaException : Exception
    {
        public AuditoriaNoCreadaException()
            : base("No se ha podido crear la auditoría.-")
        {
        }

        public AuditoriaNoCreadaException(string mensaje)
            : base(mensaje)
        {
        }

        public AuditoriaNoCreadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar una auditoría buscada.-
    /// </summary>
    public class AuditoriaNoEncontradaException : Exception
    {
        public AuditoriaNoEncontradaException()
            : base("No se ha podido encontrar la auditoría especificada.-")
        {
        }

        public AuditoriaNoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public AuditoriaNoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se encuentra una auditoría con datos no válidos.-
    /// </summary>
    public class AuditoriaNoValidaException : Exception
    {
        public AuditoriaNoValidaException()
            : base("La auditoría tiene datos no válidos.-")
        {
        }

        public AuditoriaNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public AuditoriaNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion

    #region EXCEPCIONES_FAMILIAS

    /// <summary>
    /// Excepción que se produce cuando se encuentra una familia con datos no válidos.-
    /// </summary>
    public class FamiliaNoValidaException : Exception
    {
        public FamiliaNoValidaException()
            : base("La familia tiene datos no válidos.-")
        {
        }

        public FamiliaNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public FamiliaNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se encuentra una familia.-
    /// </summary>
    public class FamiliaNoEncontradaException : Exception
    {
        public FamiliaNoEncontradaException()
            : base("No se ha podido hallar la familia buscada.-")
        {
        }

        public FamiliaNoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public FamiliaNoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede crear una familia.-
    /// </summary>
    public class FamiliaNoCreadaException : Exception
    {
        public FamiliaNoCreadaException()
            : base("No se ha podido crear una familia.-")
        {
        }

        public FamiliaNoCreadaException(string mensaje)
            : base(mensaje)
        {
        }

        public FamiliaNoCreadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede actualizar una familia.-
    /// </summary>
    public class FamiliaNoActualizadaException : Exception
    {
        public FamiliaNoActualizadaException()
            : base("No se ha podido actualizar la familia.-")
        {
        }

        public FamiliaNoActualizadaException(string mensaje)
            : base(mensaje)
        {
        }

        public FamiliaNoActualizadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion

    #region EXCEPCIONES_CODIGOS_DE_BARRAS

    /// <summary>
    /// Excepción que se produce cuando se encuentra un código de barras con datos no válidos.-
    /// </summary>
    public class CodigoDeBarrasNoValidoException : Exception
    {
        public CodigoDeBarrasNoValidoException()
            : base("El código de barras tiene datos no válidos.-")
        {
        }

        public CodigoDeBarrasNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeBarrasNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se encuentra un código de barras.-
    /// </summary>
    public class CodigoDeBarrasNoEncontradoException : Exception
    {
        public CodigoDeBarrasNoEncontradoException()
            : base("No se ha podido hallar el código de barras buscado.-")
        {
        }

        public CodigoDeBarrasNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeBarrasNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede crear un código de barras.-
    /// </summary>
    public class CodigoDeBarrasNoCreadoException : Exception
    {
        public CodigoDeBarrasNoCreadoException()
            : base("No se ha podido crear el código de barras.-")
        {
        }

        public CodigoDeBarrasNoCreadoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeBarrasNoCreadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede actualizar un código de barras.-
    /// </summary>
    public class CodigoDeBarrasNoActualizadoException : Exception
    {
        public CodigoDeBarrasNoActualizadoException()
            : base("No se ha podido actualizar el código de barras.-")
        {
        }

        public CodigoDeBarrasNoActualizadoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeBarrasNoActualizadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se intenta crear un código de barras que ya existe.-
    /// </summary>
    public class CodigoDeBarrasRepetidoException : Exception
    {
        public CodigoDeBarrasRepetidoException()
            : base("El código de barras se encuentra repetido.-")
        {
        }

        public CodigoDeBarrasRepetidoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeBarrasRepetidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede relacionar un código de barras con una entidad.-
    /// </summary>
    public class CodigoDeBarrasNoAgregadoException : Exception
    {
        public CodigoDeBarrasNoAgregadoException()
            : base("El código de barras no se pudo agregar al artículo.-")
        {
        }

        public CodigoDeBarrasNoAgregadoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeBarrasNoAgregadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede eliminar un código de barras.-
    /// </summary>
    public class CodigoDeBarrasNoEliminadoException : Exception
    {
        public CodigoDeBarrasNoEliminadoException()
            : base("El código de barras no se pudo eliminar.-")
        {
        }

        public CodigoDeBarrasNoEliminadoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeBarrasNoEliminadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }


    #endregion

    #region EXCEPCIONES_Articulos

    /// <summary>
    /// Excepción que se produce cuando no se puede crear un artículo.-
    /// </summary>
    public class ArticuloNoCreadoException : Exception
    {
        public ArticuloNoCreadoException()
            : base("No se ha podido crear el artículo.-")
        {
        }

        public ArticuloNoCreadoException(string mensaje)
            : base(mensaje)
        {
        }

        public ArticuloNoCreadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un artículo.-
    /// </summary>
    public class ArticuloNoEncontradoException : Exception
    {
        public ArticuloNoEncontradoException()
            : base("No se ha podido encontrar el artículo.-")
        {
        }

        public ArticuloNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public ArticuloNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se encuentra un artículo con datos no válidos.-
    /// </summary>
    public class ArticuloNoValidoException : Exception
    {
        public ArticuloNoValidoException()
            : base("El artículo buscado contiene datos no válidos.-")
        {
        }

        public ArticuloNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public ArticuloNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede cambiar un artículo.-
    /// </summary>
    public class ArticuloNoCambiadoException : Exception
    {
        public ArticuloNoCambiadoException()
            : base("No se ha podido cambiar el artículo.-")
        {
        }

        public ArticuloNoCambiadoException(string mensaje)
            : base(mensaje)
        {
        }

        public ArticuloNoCambiadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede deshabilitar un artículo.-
    /// </summary>
    public class ArticuloNoDeshabilitadoException : Exception
    {
        public ArticuloNoDeshabilitadoException()
            : base("No se ha podido crear el artículo.-")
        {
        }

        public ArticuloNoDeshabilitadoException(string mensaje)
            : base(mensaje)
        {
        }

        public ArticuloNoDeshabilitadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede habilitar un artículo.-
    /// </summary>
    public class ArticuloNoHabilitadoException : Exception
    {
        public ArticuloNoHabilitadoException()
            : base("No se ha podido crear el artículo.-")
        {
        }

        public ArticuloNoHabilitadoException(string mensaje)
            : base(mensaje)
        {
        }

        public ArticuloNoHabilitadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion

    #region EXCEPCIONES_OBSERVACIONES

    /// <summary>
    /// Excepción que se produce cuando no es posible crear una observación.-
    /// </summary>
    public class ObservacionNoCreadaException : Exception
    {
        public ObservacionNoCreadaException()
            : base("No se ha podido crear la observación.-")
        {
        }

        public ObservacionNoCreadaException(string mensaje)
            : base(mensaje)
        {
        }

        public ObservacionNoCreadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no es posible encontrar una observación.-
    /// </summary>
    public class ObservacionNoEncontradaException : Exception
    {
        public ObservacionNoEncontradaException()
            : base("No se ha podido encontrar una observación con el Id especificado.-")
        {
        }

        public ObservacionNoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public ObservacionNoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se encuentra una observación con datos no válidos.-
    /// </summary>
    public class ObservacionNoValidaException : Exception
    {
        public ObservacionNoValidaException()
            : base("La observación tiene datos no válidos.-")
        {
        }

        public ObservacionNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public ObservacionNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no es posible actualizar una observación.-
    /// </summary>
    public class ObservacionNoActualizadaException : Exception
    {
        public ObservacionNoActualizadaException()
            : base("No se ha actualizado la observación.-")
        {
        }

        public ObservacionNoActualizadaException(string mensaje)
            : base(mensaje)
        {
        }

        public ObservacionNoActualizadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no es posible relacionar una observación con otro objeto.-
    /// </summary>
    public class ObservacionNoRelacionadaException : Exception
    {
        public ObservacionNoRelacionadaException()
            : base("No se ha actualizado la observación.-")
        {
        }

        public ObservacionNoRelacionadaException(string mensaje)
            : base(mensaje)
        {
        }

        public ObservacionNoRelacionadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no es posible agregar una observación a la lista de otro objeto.-
    /// </summary>
    public class ObservacionNoAgregadaException : Exception
    {
        public ObservacionNoAgregadaException()
            : base("No se ha agregado la observación.-")
        {
        }

        public ObservacionNoAgregadaException(string mensaje)
            : base(mensaje)
        {
        }

        public ObservacionNoAgregadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no es posible eliminar una observación de la lista de otro objeto.-
    /// </summary>
    public class ObservacionNoEliminadaException : Exception
    {
        public ObservacionNoEliminadaException()
            : base("No se ha eliminado la observación.-")
        {
        }

        public ObservacionNoEliminadaException(string mensaje)
            : base(mensaje)
        {
        }

        public ObservacionNoEliminadaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }


    #endregion

    #region EXCEPCIONES_AlícuotasIVA

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar una alícuota de IVA buscada.-
    /// </summary>
    public class AlicuotaDeIVANoEncontradaException : Exception
    {
        public AlicuotaDeIVANoEncontradaException()
            : base("No se ha podido encontrar la alícuota buscada.-")
        {
        }

        public AlicuotaDeIVANoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public AlicuotaDeIVANoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta una alícuota de IVA con datos inválidos.-
    /// </summary>
    public class AlicuotaDeIVANoValidaException : Exception
    {
        public AlicuotaDeIVANoValidaException()
            : base("La alícuota tiene datos inválidos.-")
        {
        }

        public AlicuotaDeIVANoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public AlicuotaDeIVANoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    #endregion

    #region EXCEPCIONES_Direcciones

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un domicilio buscado.-
    /// </summary>
    public class DomicilioNoEncontradoException: Exception
    {
        public DomicilioNoEncontradoException()
            : base("No se ha podido encontrar el domicilio buscado.-")
        {
        }

        public DomicilioNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public DomicilioNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta un domicilio con datos inválidos.-
    /// </summary>
    public class DomicilioNoValidoException: Exception
    {
        public DomicilioNoValidoException()
            : base("El domicilio tiene datos inválidos.-")
        {
        }

        public DomicilioNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public DomicilioNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede crear un domicilio.-
    /// </summary>
    public class DomicilioNoCreadoException: Exception
    {
        public DomicilioNoCreadoException()
            : base("El domicilio no se ha podido crear.-")
        {
        }

        public DomicilioNoCreadoException(string mensaje)
            : base(mensaje)
        {
        }

        public DomicilioNoCreadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede actualizar un domicilio.-
    /// </summary>
    public class DomicilioNoActualizadoException : Exception
    {
        public DomicilioNoActualizadoException()
            : base("El domicilio no se ha podido actualizar.-")
        {
        }

        public DomicilioNoActualizadoException(string mensaje)
            : base(mensaje)
        {
        }

        public DomicilioNoActualizadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede agregar un domicilio a una entidad.-
    /// </summary>
    public class DomicilioNoAgregadoException : Exception
    {
        public DomicilioNoAgregadoException()
            : base("El domicilio no se ha podido agregar.-")
        {
        }

        public DomicilioNoAgregadoException(string mensaje)
            : base(mensaje)
        {
        }

        public DomicilioNoAgregadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede eliminar un domicilio en sí o cuando no puede eliminarse de una entidad.-
    /// </summary>
    public class DomicilioNoEliminadoException : Exception
    {
        public DomicilioNoEliminadoException()
            : base("El domicilio no se ha podido eliminar.-")
        {
        }

        public DomicilioNoEliminadoException(string mensaje)
            : base(mensaje)
        {
        }

        public DomicilioNoEliminadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }
    #endregion

    #region EXCEPCIONES_Telefonos

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un teléfono buscado.-
    /// </summary>
    public class TelefonoNoEncontradoException : Exception
    {
        public TelefonoNoEncontradoException()
            : base("No se ha podido encontrar el teléfono buscado.-")
        {
        }

        public TelefonoNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public TelefonoNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta un teléfono con datos inválidos.-
    /// </summary>
    public class TelefonoNoValidoException : Exception
    {
        public TelefonoNoValidoException()
            : base("El teléfono tiene datos inválidos.-")
        {
        }

        public TelefonoNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public TelefonoNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede crear un teléfono.-
    /// </summary>
    public class TelefonoNoCreadoException : Exception
    {
        public TelefonoNoCreadoException()
            : base("El teléfono no se ha podido crear.-")
        {
        }

        public TelefonoNoCreadoException(string mensaje)
            : base(mensaje)
        {
        }

        public TelefonoNoCreadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede actualizar un teléfono.-
    /// </summary>
    public class TelefonoNoActualizadoException : Exception
    {
        public TelefonoNoActualizadoException()
            : base("El teléfono no se ha podido actualizar.-")
        {
        }

        public TelefonoNoActualizadoException(string mensaje)
            : base(mensaje)
        {
        }

        public TelefonoNoActualizadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no puede agregarse un teléfono a una entidad.-
    /// </summary>
    public class TelefonoNoAgregadoException : Exception
    {
        public TelefonoNoAgregadoException()
            : base("No se ha podido agregar el teléfono.-")
        {
        }

        public TelefonoNoAgregadoException(string mensaje)
            : base(mensaje)
        {
        }

        public TelefonoNoAgregadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no puede eliminarse.-
    /// </summary>
    public class TelefonoNoEliminadoException : Exception
    {
        public TelefonoNoEliminadoException()
            : base("No se ha podido eliminar el teléfono.-")
        {
        }

        public TelefonoNoEliminadoException(string mensaje)
            : base(mensaje)
        {
        }

        public TelefonoNoEliminadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }



    #endregion

    #region EXCEPCIONES_TiposDeDocumento

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un tipo de documento buscado.-
    /// </summary>
    public class TipoDeDocumentoNoEncontradoException : Exception
    {
        public TipoDeDocumentoNoEncontradoException()
            : base("No se ha podido encontrar el tipo de documento buscado.-")
        {
        }

        public TipoDeDocumentoNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public TipoDeDocumentoNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta un tipo de documento con datos inválidos.-
    /// </summary>
    public class TipoDeDocumentoNoValidoException : Exception
    {
        public TipoDeDocumentoNoValidoException()
            : base("El tipo de documento tiene datos inválidos.-")
        {
        }

        public TipoDeDocumentoNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public TipoDeDocumentoNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }
    #endregion

    #region EXCEPCIONES_PRECIOS

    /// <summary>
    /// Excepción que se produce cuando no se puede crear un artículo.-
    /// </summary>
    public class PrecioNoValidoException : Exception
    {
        public PrecioNoValidoException()
            : base("El precio informado no es válido.-")
        {
        }

        public PrecioNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public PrecioNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }




#endregion

    #region EXCEPCIONES_GENERICAS

    /// <summary>
    /// Excepción que produce cuando se detecta un código no válido.-
    /// </summary>
    public class CodigoNoValidoException : Exception
    {
        public CodigoNoValidoException()
            : base("El código informado no es válido.-")
        {
        }

        public CodigoNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que produce cuando se detecta un nombre duplicado.-
    /// </summary>
    public class NombreRepetidoException: Exception
    {
        public NombreRepetidoException()
            : base("El nombre informado ya existe.-")
        {
        }

        public NombreRepetidoException(string mensaje)
            : base(mensaje)
        {
        }

        public NombreRepetidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que produce cuando se detecta una descripción vacía.-
    /// </summary>
    public class DescripcionVaciaException : Exception
    {
        public DescripcionVaciaException()
            : base("La descripción recibida está vacía.-")
        {
        }

        public DescripcionVaciaException(string mensaje)
            : base(mensaje)
        {
        }

        public DescripcionVaciaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta una descripción cuya longitud que supera el máximo estipulado.-
    /// </summary>
    public class DescripcionMuyLargaException : Exception
    {
        public DescripcionMuyLargaException()
            : base("La descripción recibida supera la longitud máxima establecida.-")
        {
        }

        public DescripcionMuyLargaException(string mensaje)
            : base(mensaje)
        {
        }

        public DescripcionMuyLargaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta una descripción repetida.-
    /// </summary>
    public class DescripcionRepetidaException : Exception
    {
        public DescripcionRepetidaException()
            : base("La descripción recibida se encuentra repetida.-")
        {
        }

        public DescripcionRepetidaException(string mensaje)
            : base(mensaje)
        {
        }

        public DescripcionRepetidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta una opción no válida.-
    /// </summary>
    public class OpcionNoValidaException : Exception
    {
        public OpcionNoValidaException()
            : base("La opción especificada no es válida.-")
        {
        }

        public OpcionNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public OpcionNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que produce cuando se detecta una descripción vacía.-
    /// </summary>
    public class IntervaloNoEncontradoException : Exception
    {
        public IntervaloNoEncontradoException()
            : base("No se ha encontrado un intervalo con el Id especificado.-")
        {
        }

        public IntervaloNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public IntervaloNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

#endregion


#region EXCEPCIONES_CodigosDeJustificacion

    /// <summary>
    /// Excepción que se produce cuando no se encuentra un Codigo de Justificación buscado.-
    /// </summary>
    public class CodigoDeJustificacionNoEncontradoException : Exception
    {
        public CodigoDeJustificacionNoEncontradoException()
            : base("Código de Justificación no encontrado.-")
        {
        }

        public CodigoDeJustificacionNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeJustificacionNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede eliminar un Codigo de Justificación.-
    /// </summary>
    public class CodigoDeJustificacionNoEliminadoException : Exception
    {
        public CodigoDeJustificacionNoEliminadoException()
            : base("Código de Justificación no eliminado.-")
        {
        }

        public CodigoDeJustificacionNoEliminadoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeJustificacionNoEliminadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta un Codigo de Justificación nulo o no válido.-
    /// </summary>
    public class CodigoDeJustificacionNoValidoException : Exception
    {
        public CodigoDeJustificacionNoValidoException()
            : base("El Código de Justificación es nulo o no válido.-")
        {
        }

        public CodigoDeJustificacionNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public CodigoDeJustificacionNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

#endregion


#region EXCEPCIONES_Miscelaneas


    /// <summary>
    /// Excepción que se produce cuando se detecta una dirección IP no válida.-
    /// </summary>
    public class IPNoValidaException : Exception
    {
        public IPNoValidaException()
            : base("La dirección IP especificada no es válida.-")
        {
        }

        public IPNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public IPNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }




#endregion


#region EXCEPCIONES_Turnos

    /// <summary>
    /// Excepción que se produce cuando se puede crear un turno.-
    /// </summary>
    public class TurnoNoCreadoException : Exception
    {
        public TurnoNoCreadoException()
            : base("No se ha podido iniciar el turno.-")
        {
        }

        public TurnoNoCreadoException(string mensaje)
            : base(mensaje)
        {
        }

        public TurnoNoCreadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un turno.-
    /// </summary>
    public class TurnoNoEncontradoException : Exception
    {
        public TurnoNoEncontradoException()
            : base("No se ha podido encontrar un turno con el Id especificado.-")
        {
        }

        public TurnoNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public TurnoNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede finalizar un turno.-
    /// </summary>
    public class TurnoNoFinalizadoException : Exception
    {
        public TurnoNoFinalizadoException()
            : base("No se ha podido finalizar el turno especificado.-")
        {
        }

        public TurnoNoFinalizadoException(string mensaje)
            : base(mensaje)
        {
        }

        public TurnoNoFinalizadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede tomar un turno.-
    /// </summary>
    public class TurnoNoTomadoException : Exception
    {
        public TurnoNoTomadoException()
            : base("No se ha podido tomar el turno.-")
        {
        }

        public TurnoNoTomadoException(string mensaje)
            : base(mensaje)
        {
        }

        public TurnoNoTomadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se detecta un turno con datos no válidos.-
    /// </summary>
    public class TurnoNoValidoException : Exception
    {
        public TurnoNoValidoException()
            : base("El turno tiene datos no válidos.-")
        {
        }

        public TurnoNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public TurnoNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

#endregion


#region EXCEPCIONES_Parametros

    /// <summary>
    /// Excepción que se produce cuando la parametrización encontrada no es válida.-
    /// </summary>
    public class ParametrizacionNoValidaException : Exception
    {
        public ParametrizacionNoValidaException()
            : base("La parametrización del sistema tiene datos no válidos.-")
        {
        }

        public ParametrizacionNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public ParametrizacionNoValidaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar la parametrización.-
    /// </summary>
    public class ParametrizacionNoEncontradaException : Exception
    {
        public ParametrizacionNoEncontradaException()
            : base("No se ha podido encontrar la parametrización del sistema.-")
        {
        }

        public ParametrizacionNoEncontradaException(string mensaje)
            : base(mensaje)
        {
        }

        public ParametrizacionNoEncontradaException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede realizar la actualización de un parámetro.-
    /// </summary>
    public class ParametroNoActualizadoException : Exception
    {
        public ParametroNoActualizadoException()
            : base("No se ha podido actualizar el parámetro.-")
        {
        }

        public ParametroNoActualizadoException(string mensaje)
            : base(mensaje)
        {
        }

        public ParametroNoActualizadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

#endregion

}
