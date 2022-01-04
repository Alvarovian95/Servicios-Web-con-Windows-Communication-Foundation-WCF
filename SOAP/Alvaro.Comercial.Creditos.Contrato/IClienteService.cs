using Alvaro.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace Alvaro.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [FaultContract(typeof(Error))]
        Cliente ObtenerCliente(string numeroDocumento);
        [OperationContract]
        [FaultContract(typeof(Error))]
        IEnumerable<Cliente> ListarClientes();
    }
}
