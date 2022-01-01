using Alvaro.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace Alvaro.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente ObtenerCliente(string numeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> ListarClientes();
    }
}
