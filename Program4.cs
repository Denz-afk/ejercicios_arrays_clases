using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] debm = new int[10];
            
            for(int i=0; i<debm.Length; i++)
            {
                Console.WriteLine("Escribe un número");
                int num = Convert.ToInt32(Console.ReadLine());
                debm[i] = num;
            }

            Array.Sort(debm);

            int debm1 = debm[debm.Length - 1];

            Console.WriteLine("El número mayor es: " + debm1);
        }
    }
}
