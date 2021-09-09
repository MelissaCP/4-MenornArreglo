using System;
using C = System.Console;

namespace _4_MenornArreglo
{
    /// Practica 4
    /// 4.- Encontrar el menor de n números en un arreglo.

    /// Chávez Pérez Melissa
    /// #M21210035
    class Program
    {
        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            C.Write("\nFavor de Ingresar cuantos numeros desea comparar ");
            int v;
            v = int.Parse(C.ReadLine());

            // Declaracion de Arreglo 
            int[] datos = new int[v];
            int x;
            for (int i=0; i<v;i++)
            {
                C.WriteLine("\nIngrese valor {0}", (i + 1));
                x = int.Parse(C.ReadLine());
                datos[i] = x;
            }
            int menor = datos[0];
            for (int i=0; i<v; i++)
            {
                if (datos[i] < menor)
                    menor = datos[i];
            }
            C.Write("\n\nEl menor de los datos es: " + menor);
            C.ReadLine();

        }
    }
}
