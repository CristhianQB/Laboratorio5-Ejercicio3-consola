using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_Ejercicio3_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nùmero de notas: ");
            float nnotas = float.Parse(Console.ReadLine());

            float sumar = 0f;
            for (int i = 1; i <= nnotas; i++)
            {
                Console.Write("Ingrese la nota " +i +" :");
                float notas = float.Parse(Console.ReadLine());
                sumar = sumar + notas;
            }
            float promedio = sumar / nnotas; 
            Console.WriteLine("El promedio es: "+promedio);
            Console.ReadKey();
        }
    }
}
