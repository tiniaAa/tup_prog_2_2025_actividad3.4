using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    public class Cilidro : Figura
    {
        public double Radio { get; set; }
        public Cilidro(double radio, double altura): base(altura)  
        {
            Radio = radio;
        }

        public override string Describir()
        {
            return $"Cilindro: Radio:{Radio}-Altura:{Altura}-Volumen{CalcularVolumen()}";

        }
        public override double CalcularVolumen()
        {

            return Math.PI * Math.Pow(Radio, 2) * Altura;
        }
    }
}
