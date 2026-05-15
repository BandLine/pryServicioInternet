using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryServicio_Internet
{
    internal abstract class TipoCliente
    {
        public string cliente;
        public float costoBase;
        public float impuesto;
        public float costoFinal;
        public float velocidad;

        public void CalcularCostoFinal()
        {
            costoFinal = costoBase + impuesto;
        }
        public abstract void CalcularCostoBase();
        public abstract void CalcularImpuesto();
    }
}
