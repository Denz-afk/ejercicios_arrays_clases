using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] debm = new int[1];
            while ((debm[0] < -1)||(debm[0] > -1))
            {
                    for(int i=0; i<debm.Length; i++)
                {
                    Console.WriteLine("Escribe un número");
                    int num = Convert.ToInt32(Console.ReadLine());
                    debm[i] = num;
                }
                if((debm[0]>-1)||(debm[0]<-1)){
                    Console.WriteLine(debm[0]+" x 1 = "+debm[0]);
                    Console.WriteLine(debm[0]+" x 2 = "+debm[0]*2);
                    Console.WriteLine(debm[0]+" x 3 = "+debm[0]*3);
                    Console.WriteLine(debm[0]+" x 4 = "+debm[0]*4);
                    Console.WriteLine(debm[0]+" x 5 = "+debm[0]*5);
                    Console.WriteLine(debm[0]+" x 6 = "+debm[0]*6);
                    Console.WriteLine(debm[0]+" x 7 = "+debm[0]*7);
                    Console.WriteLine(debm[0]+" x 8 = "+debm[0]*8);
                    Console.WriteLine(debm[0]+" x 9 = "+debm[0]*9);
                    Console.WriteLine(debm[0]+" x 10 = "+debm[0]*10);
                    Console.WriteLine(debm[0]+" x 11 = "+debm[0]*11);
                    Console.WriteLine(debm[0]+" x 12 = "+debm[0]*12);
                }                
            }            
        }
    }
}
