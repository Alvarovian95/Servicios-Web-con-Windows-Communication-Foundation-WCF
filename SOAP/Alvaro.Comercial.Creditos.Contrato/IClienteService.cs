using Alvaro.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Alvaro.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebGet(
            RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json, 
            UriTemplate = "/ObtenerCliente/{numeroDocumento}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        [FaultContract(typeof(Error))]
        Cliente ObtenerCliente(string numeroDocumento);

        [OperationContract]
        [WebGet(
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ListarClientes",
            BodyStyle = WebMessageBodyStyle.Bare)]
        [FaultContract(typeof(Error))]
        IEnumerable<Cliente> ListarClientes();
    }
}
