using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    public class Ortoedro : Figura
    {
        public double Ancho;
        public double Largo;
        public double Alto;

        public Ortoedro(double ancho, double alto, double largo):base (alto)
        {
            Ancho = ancho;  
            Largo = largo;
            Alto = alto;
        }

        public override string Describir()
        {
            return $"Altura: {Alto}-Largo{Largo}-Ancho{Ancho}-Volumen{CalcularVolumen()}"; 
        }
        public override double CalcularVolumen()
        {
            return Ancho*Alto*Largo; 
        }
    }
}
