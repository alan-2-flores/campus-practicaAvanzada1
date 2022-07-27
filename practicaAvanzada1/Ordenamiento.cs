using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaAvanzada1
{
    public class Ordenamiento<T>
    {
        public Func<List<T>, List<T>> ordenarAsc = lista => {
            List<T> listaOrdenada = new List<T>();
            listaOrdenada = lista.OrderBy(x => x).ToList();
            return listaOrdenada;
        };

        public Func<List<T>, List<T>> ordenarDesc = lista => {
            List<T> listaOrdenada = new List<T>();
            listaOrdenada = lista.OrderByDescending(x => x).ToList();
            return listaOrdenada;
        };

        public Action<List<T>> imprimir = array => {
            foreach (var valor in array)
            {
                Console.WriteLine(valor);
            }
        };
    }
}
