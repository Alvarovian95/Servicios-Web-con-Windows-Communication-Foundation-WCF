using Alvaro.Comercial.Creditos.ContratoRepositorio;
using Alvaro.Comercial.Creditos.Dominio;
using Alvaro.Comercial.Creditos.SqlRepositorio;
using System;
using System.Collections.Generic;

namespace Alvaro.Comercial.Creditos.Fachada
{
    public class ClienteFachada : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Cliente> ListarClientes()
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ListarClientes();
        }

        public Cliente ObtenerCliente(string numeroDocumento)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ObtenerCliente(numeroDocumento);
        }
    }
}
