using Alvaro.Comercial.Creditos.ContratoRepositorio;
using Alvaro.Comercial.Creditos.Dominio;
using Alvaro.Comercial.Creditos.SqlRepositorio;
using System;
using System.Collections.Generic;

namespace Alvaro.Comercial.Creditos.Fachada
{
    public class CreditoFachada : IDisposable
    {
        public IEnumerable<Credito> ListarCredito()
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ListarCredito();
        }

        public Credito RegistrarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.RegistrarCredito(credito);
        }

        public Credito ActualizarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ActualizarCredito(credito);
        }

        public bool EliminarCredito(string idCredito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.EliminarCredito(idCredito);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
