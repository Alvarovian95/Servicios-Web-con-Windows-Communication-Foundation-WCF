using Alvaro.Comercial.Creditos.Contrato;
using Alvaro.Comercial.Creditos.Dominio;
using Alvaro.Comercial.Creditos.Fachada;
using System.Collections.Generic;

namespace Alvaro.Comercial.Creditos.Implementacion
{
    public class CreditoService : ICreditoService
    {
        public Credito ActualizarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ActualizarCredito(credito);
            }
        }

        public bool EliminarCredito(string idCredito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.EliminarCredito(idCredito);
            }
        }

        public IEnumerable<Credito> ListarCredito()
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ListarCredito();
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.RegistrarCredito(credito);
            }
        }
    }
}
