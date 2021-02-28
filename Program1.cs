using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] debm = new int[4];

            for(int i=0; i<debm.Length; i++)
            {
                Console.WriteLine("Escribe un número");
                int num = Convert.ToInt32(Console.ReadLine());
                debm[i] = num;
            }

            int debm1 = 0;
            for (int i = 0; i<debm.Length; i++)
            {
                debm1 += debm[i];
            }

            Double debm2 = (Double) debm1 / debm.Length;

            Console.WriteLine("El promedio es: "+debm2);
            Console.WriteLine("Los datos ingresados fueron: ");
            for(int i=0; i<debm.Length; i++)
            {
                Console.WriteLine(debm[i]);
            }
        }
    }
}
