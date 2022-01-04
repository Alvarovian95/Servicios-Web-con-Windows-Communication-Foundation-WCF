using System.Collections.Generic;
using Alvaro.Comercial.Creditos.Dominio;
using System.ServiceModel.Web;
using System.ServiceModel;

namespace Alvaro.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface ICreditoService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Credito> ListarCredito();

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", UriTemplate = "/RegistrarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito RegistrarCredito(Credito credito);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/ActualizarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito ActualizarCredito(Credito credito);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "DELETE", UriTemplate = "/EliminarCredito/{idCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito EliminarCredito(int idCredito);
    }
}
