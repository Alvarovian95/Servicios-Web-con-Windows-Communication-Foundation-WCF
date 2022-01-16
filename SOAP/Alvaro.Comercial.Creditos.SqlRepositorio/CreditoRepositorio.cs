using Alvaro.Comercial.Creditos.ContratoRepositorio;
using Alvaro.Comercial.Creditos.Dominio;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alvaro.Comercial.Creditos.SqlRepositorio
{
    public class CreditoRepositorio : ICreditoRepositorio
    {
        public Credito ActualizarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();

                var parametro = new DynamicParameters();

                parametro.Add("IdCredito", credito.IdCredito);
                parametro.Add("TipoCredito", credito.TipoCredito);
                parametro.Add("IdCliente", credito.IdCliente);
                parametro.Add("Fecha", credito.Fecha);
                parametro.Add("Cantidad", credito.Cantidad);
                parametro.Add("DiaPago", credito.DiaPago);
                parametro.Add("Tasa", credito.Tasa);
                parametro.Add("Comision", credito.Comisiones);

                var result = conexion.Execute("dbo.sp_Credito_actualizar", param: parametro, commandType: CommandType.StoredProcedure);

                return result > 0 ? credito : new Credito();
            }
        }

        public bool EliminarCredito(string idCredito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();

                var parametro = new DynamicParameters();
                parametro.Add("IdCredito", idCredito);

                var result = conexion.Execute("dbo.sp_Credito_eliminar", param: parametro, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public IEnumerable<Credito> ListarCredito()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var credito = conexion.Query<Credito>("dbo.sp_Credito_listar", commandType: CommandType.StoredProcedure);
                return credito;
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();

                var parametro = new DynamicParameters();

                parametro.Add("TipoCredito", credito.TipoCredito);
                parametro.Add("IdCliente", credito.IdCliente);
                parametro.Add("Fecha", credito.Fecha);
                parametro.Add("Cantidad", credito.Cantidad);
                parametro.Add("DiaPago", credito.DiaPago);
                parametro.Add("Tasa", credito.Tasa);
                parametro.Add("Comision", credito.Comisiones);
                parametro.Add("IdCredito", credito.IdCredito, DbType.Int32, ParameterDirection.Output);

                var result = conexion.ExecuteScalar("dbo.sp_Credito_registrar", param: parametro, commandType: CommandType.StoredProcedure);
                var pIdCredito = parametro.Get<Int32>("IdCredito");
                credito.IdCredito = pIdCredito;
                return credito;
            }
        }
    }
}
