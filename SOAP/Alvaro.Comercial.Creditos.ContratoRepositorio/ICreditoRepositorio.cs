using Alvaro.Comercial.Creditos.Dominio;
using System.Collections.Generic;

namespace Alvaro.Comercial.Creditos.ContratoRepositorio
{
    public interface ICreditoRepositorio
    {     
        IEnumerable<Credito> ListarCredito();

        Credito RegistrarCredito(Credito credito);

        Credito ActualizarCredito(Credito credito);

        bool EliminarCredito(string idCredito);
    }
}
