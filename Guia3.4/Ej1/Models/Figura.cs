using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    public abstract class Figura :IComparable
    {
        public double Altura;


        public Figura(double altura)
        {
            Altura = altura;
        }
        public abstract string Describir();

        public virtual double CalcularVolumen()
        {
            return 0 ; 
        }
        public override string ToString()
        {
            return Describir(); 
        }

        public int CompareTo(Object obj)
        {
            Figura otraFigura = obj as Figura;
            if (otraFigura != null)
            {
                return CalcularVolumen().CompareTo(otraFigura.CalcularVolumen());
            }



            return -1; 
        }
    }
}
