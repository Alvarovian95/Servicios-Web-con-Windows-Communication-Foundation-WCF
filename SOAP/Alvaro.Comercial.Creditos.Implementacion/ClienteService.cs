using Alvaro.Comercial.Creditos.Contrato;
using Alvaro.Comercial.Creditos.Dominio;
using Alvaro.Comercial.Creditos.Fachada;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Alvaro.Comercial.Creditos.Implementacion
{
    public class ClienteService : IClienteService
    {
        public IEnumerable<Cliente> ListarClientes()
        {
            try
            {
                using (var instancia = new ClienteFachada())
                {
                    return instancia.ListarClientes();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException<Error>(new Error()
                {
                    CodigoError = "1001",
                    Descripcion = "Excepcion administrada por el servicio",
                    MensajeError = ex.Message
                });
            }
        }

        public Cliente ObtenerCliente(string numeroDocumento)
        {
            try
            {
                using (var instancia = new ClienteFachada())
                {
                    return instancia.ObtenerCliente(numeroDocumento);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException<Error>(new Error()
                {
                    CodigoError = "1001",
                    Descripcion = "Excepcion administrada por el servicio",
                    MensajeError = ex.Message
                });
            }

        }
    }
}
