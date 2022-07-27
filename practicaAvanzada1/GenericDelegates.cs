using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaAvanzada1
{
    public class GenericDelegates<T>
    {
        public Action<T> imprimirAction = valor => Console.WriteLine($"\nImprimir cualquier valor de entrada {valor}");
        public Predicate<List<T>> estaVacioPredicate = entrada => entrada.Count == 0;
    }
}
