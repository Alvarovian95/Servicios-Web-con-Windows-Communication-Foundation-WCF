using Alvaro.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace Alvaro.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente ObtenerCliente(string NumeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> ListarClientes();
    }
}
