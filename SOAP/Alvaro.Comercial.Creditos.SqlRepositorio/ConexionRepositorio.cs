using System.Configuration;

namespace Alvaro.Comercial.Creditos.SqlRepositorio
{
    public class ConexionRepositorio
    {
        public static string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["CreditosDB"].ToString();
        }
    }
}
