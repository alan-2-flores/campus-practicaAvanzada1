using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaAvanzada1
{
    public class Valores
    {
        public Predicate<int> multiploDe3 = n => n % 3 == 0;

        public Func<int[], int> maxValue = array => array.Max();

        public Func<int[], int> minValue = array => array.Min();

        public Func<int[], double> avgValue = array => array.Average();

        public Func<int[], double> RMS = array => {
            double resultado=0;
            foreach (var valor in array)
            {
                resultado = resultado + (valor*valor);
            }
            resultado = resultado / array.Length;
            resultado = Math.Sqrt(resultado);
            return resultado;
        };
    }
}
