using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace coca
{

    /// <summary>
    /// 
    /// </summary>
    class iSeries
    {
        public const int intevaloValidezDeCredenciales = 240;    //4 horas = 240 minutos
        private static string archivoCredenciales = "ibmi.series";
        private static string rutaCredenciales;

        /// <summary>
        /// Obtiene las credenciales para conectarse al Db2 for i
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="CredencialesNoValidasException"></exception>
        /// <exception cref="CredencialesExpiradasException"></exception>
        public static List<string> ObtenerCredenciales()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            List<string> parametrosDeConexion;

            myAssembly = Assembly.GetExecutingAssembly();
            rutaCredenciales = Path.GetDirectoryName(myAssembly.Location);

            //Chequear si existe el archivo.-
            if (!File.Exists(rutaCredenciales + Path.DirectorySeparatorChar + archivoCredenciales))
                throw new FileNotFoundException("No se ha encontrado el archivo de credenciales.");

            //Obtener las credenciales y el sistema.-
            parametrosDeConexion = new List<string>();
            using (StreamReader fr = new StreamReader(rutaCredenciales + Path.DirectorySeparatorChar + archivoCredenciales))
            {
                string renglon;
                while ((renglon = fr.ReadLine()) != null)
                {
                    renglon = System.Text.Encoding.UTF8.GetString((System.Convert.FromBase64String(renglon)));
                    parametrosDeConexion.Add(renglon);
                }
            }

            //Si no se recuperan 4 parámetros, se arroja una excepcion.
            if (parametrosDeConexion.Count != 4)
                throw new CredencialesNoValidasException("No se han encontrado credenciales válidas.");

            //Se valida que las credenciales no tengan más de 24 hs de antiguedad.-
            int aaaa = System.Convert.ToInt32(parametrosDeConexion[3].Substring(0, 4));
            int mes = System.Convert.ToInt32(parametrosDeConexion[3].Substring(4, 2));
            int dia = System.Convert.ToInt32(parametrosDeConexion[3].Substring(6, 2));
            int hora = System.Convert.ToInt32(parametrosDeConexion[3].Substring(9, 2));
            int minutos = System.Convert.ToInt32(parametrosDeConexion[3].Substring(11, 2));
            int segundos = System.Convert.ToInt32(parametrosDeConexion[3].Substring(13, 2));

            DateTime fechaDeCredenciales = new DateTime(aaaa, mes, dia, hora, minutos, segundos);
            DateTime fechaActual = DateTime.Now;

            TimeSpan ts = new TimeSpan();
            ts = fechaActual - fechaDeCredenciales;
            double minutosDeCredenciales = ts.TotalMinutes;

            if (minutosDeCredenciales > intevaloValidezDeCredenciales) 
                throw new CredencialesExpiradasException("Credenciales expiradas. Se necesitan nuevas.");

            return parametrosDeConexion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        public static void BorrarCredenciales()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();


            myAssembly = Assembly.GetExecutingAssembly();
            rutaCredenciales = Path.GetDirectoryName(myAssembly.Location);

            //Chequear si existe el archivo.-
            if (!File.Exists(rutaCredenciales + Path.DirectorySeparatorChar + archivoCredenciales))
                throw new FileNotFoundException("No se ha encontrado el archivo de credenciales.");

            File.Delete(rutaCredenciales + Path.DirectorySeparatorChar + archivoCredenciales);
        }

    }
}
