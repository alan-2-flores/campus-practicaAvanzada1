using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaAvanzada1
{
    public class ParesImpares
    {
        public Func<int[], int[]> pares = array =>
        {
            int i = 0;
            foreach (int valor in array)
            {
                if (valor % 2 == 0)
                    i++;
            }
            int[] resultado = new int[i];
            i = 0;
            foreach (int valor in array)
            {
                if (valor % 2 == 0)
                    resultado[i++] = valor;
            }
            return resultado;
        };

        public Func<int[], int[]> impares = array =>
        {
            int i = 0;
            foreach (int valor in array)
            {
                if (valor % 2 != 0)
                    i++;
            }
            int[] resultado = new int[i];
            i = 0;
            foreach (int valor in array)
            {
                if (valor % 2 != 0)
                    resultado[i++] = valor;
            }
            return resultado;
        };

        public Action<int[]> imprimir = array => {
            foreach (int valor in array)
            {
                Console.WriteLine(valor);
            }
        };
    }
}
