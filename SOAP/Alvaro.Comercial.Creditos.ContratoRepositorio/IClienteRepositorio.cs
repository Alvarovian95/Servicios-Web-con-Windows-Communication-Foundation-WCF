using Alvaro.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alvaro.Comercial.Creditos.ContratoRepositorio
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> ListarClientes();
        Cliente ObtenerCliente(string numeroDocumento);
    }
}

