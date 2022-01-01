using Alvaro.Comercial.Creditos.Contrato;
using Alvaro.Comercial.Creditos.Dominio;
using Alvaro.Comercial.Creditos.Fachada;
using System.Collections.Generic;

namespace Alvaro.Comercial.Creditos.Implementacion
{
    public class ClienteService : IClienteService
    {
        public IEnumerable<Cliente> ListarClientes()
        {
            using (var instancia = new ClienteFachada())
            {
                return instancia.ListarClientes();
            }
        }

        public Cliente ObtenerCliente(string numeroDocumento)
        {
            using(var instancia = new ClienteFachada())
            {
                return instancia.ObtenerCliente(numeroDocumento);
            }
        }
    }
}
