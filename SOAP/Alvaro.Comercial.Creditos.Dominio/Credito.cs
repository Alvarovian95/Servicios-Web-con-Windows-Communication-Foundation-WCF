using System;
using System.Runtime.Serialization;

namespace Alvaro.Comercial.Creditos.Dominio
{
    [DataContract]
    class Credito
    {
        [DataMember]
        public int IdCredito { get; set; }
        [DataMember]
        public int TipoCredito { get; set; }
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public Decimal Cantidad { get; set; }
        [DataMember]
        public DateTime DiaPago { get; set; }
        [DataMember]
        public Decimal Tasa { get; set; }
        [DataMember]
        public Decimal Comisiones { get; set; }
    }
}
