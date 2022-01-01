using Alvaro.Comercial.Creditos.Dominio;
using Alvaro.Comercial.Creditos.ContratoRepositorio;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Alvaro.Comercial.Creditos.SqlRepositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public IEnumerable<Cliente> ListarClientes()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var cliente = conexion.Query<Cliente>("dbo.sp_cliente_listar",commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }
        public Cliente ObtenerCliente(string numeroDocumento)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("pNumeroDocumento", numeroDocumento);

                var cliente = conexion.QuerySingle<Cliente>
                    (
                        "dbo.sp_cliente_obtener",
                        param: parametros,
                        commandType: CommandType.StoredProcedure
                    );
                return cliente;
            }
        }
    }
}
