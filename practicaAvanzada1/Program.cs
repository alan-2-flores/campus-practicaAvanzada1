using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaAvanzada1
{
    internal class Program
    {
        static void Main()
        {
            //Puntos 1 y 2
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ParesImpares paresImpares = new ParesImpares();
            int[] nPares = paresImpares.pares(numeros);
            int[] nImpares = paresImpares.impares(numeros);

            Console.WriteLine("PARES");
            paresImpares.imprimir(nPares);

            Console.WriteLine("\nIMPARES");
            paresImpares.imprimir(nImpares);

            Console.ReadKey();

            //Puntos 3 y 4
            int[] desordenado = new int[] { 25,41,12,36,98,56,28,41,52,2,54,2,7,6 };
            Ordenamiento<int> ordenamiento = new Ordenamiento<int>();
            List<int> pruebaOrdenamiento = new List<int>();

            pruebaOrdenamiento = ordenamiento.ordenarAsc(desordenado.ToList());
            Console.WriteLine("\nORDENAMIENTO ASC");
            ordenamiento.imprimir(pruebaOrdenamiento);

            pruebaOrdenamiento = ordenamiento.ordenarDesc(desordenado.ToList());
            Console.WriteLine("\nORDENAMIENTO DESC");
            ordenamiento.imprimir(pruebaOrdenamiento);

            Console.ReadKey();

            //Puntos 5, 7, 8, 9
            int n3=3;
            Valores valores = new Valores();
            Console.WriteLine($"\nEl numero {n3} multiplo de 3: {valores.multiploDe3(n3)}");
            Console.WriteLine($"El valor maximo del arreglo es: {valores.maxValue(desordenado)}");
            Console.WriteLine($"El valor minimo del arreglo es: {valores.minValue(desordenado)}");
            Console.WriteLine($"El valor promedio del arreglo es: {valores.avgValue(desordenado)}");
            Console.ReadKey();

            //Punto 10
            int[] numerosRMS = new int[] { 2, 3, 5, 6, 7 };
            Console.WriteLine($"\nEl valor RMS del arreglo es: {valores.RMS(numerosRMS)}");
            Console.ReadKey();

            //Punto 6 y 11
            List<int> listaVacia=new List<int>();
            GenericDelegates<int> genericDelegates = new GenericDelegates<int>();
            genericDelegates.imprimirAction(2);
            Console.WriteLine($"Viendo si esta vacio con predicate {genericDelegates.estaVacioPredicate(listaVacia)}");
            //En ordenamiento.ordenarAsc y ordenamiento.ordenarDesc
            //se hace uso de generic en los delegados
            Console.ReadKey();

        }
    }
}
