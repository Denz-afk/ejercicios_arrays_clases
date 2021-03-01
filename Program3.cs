using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] debm = new int[13];
            
            debm[1] = 31;
            debm[2] = 28;
            debm[3] = 31;
            debm[4] = 30;
            debm[5] = 31;
            debm[6] = 30;
            debm[7] = 31;
            debm[8] = 31;
            debm[9] = 30;
            debm[10] = 31;
            debm[11] = 30;
            debm[12] = 31;

            Console.WriteLine("ingrese el numero del mes: ");
            int debm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tiene " + debm[debm1] + " días ");

            Console.ReadKey();
        }
    }
}
