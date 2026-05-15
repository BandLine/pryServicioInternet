using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryServicio_Internet
{
    internal class Empresarial: TipoCliente
    {
        public float soporte;
        public override void CalcularCostoBase()
        {
            costoBase = velocidad * 20 + soporte;
        }

        public override void CalcularImpuesto()
        {
            impuesto = costoBase * 0.10f;
        }
    }
}
