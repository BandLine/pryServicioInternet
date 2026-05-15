using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryServicio_Internet
{
    internal class Hogar: TipoCliente
    {
        //override sobreescritura: siempre se da por la herencia.
        //overload sobrecarga: se da dentro de la misma clase, con el mismo nombre pero con diferente cantidad o tipo de parametros.
        public override void CalcularCostoBase()
        {
            costoBase = velocidad * 10;
        }

        public override void CalcularImpuesto()
        {
            impuesto = costoBase * 0.8f;
        }
    }
}
