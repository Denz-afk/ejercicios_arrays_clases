using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int debm1 = 0;
            float[] numeros = new float[5];
            do
            {
                Console.WriteLine("Escribe un número: ");
                numeros[debm1] = float.Parse(Console.ReadLine());
                debm1++;
            }
            while (debm1 < 5);
            if (debm1 >= 5)
            {
                Array.Reverse(numeros);
                Console.WriteLine("El orden contrario es: ");
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}
