using System;

namespace E21_Garciagonzalez
{
    public class Factorial
    {
        public void ciclofor()
        {
            int total = 1;
            for (int i = 1; i < 7; i++)
            {
                total = total * i;
                Console.WriteLine(total);
            }

        }
        public int Recursividad(int n)
        {
            if( n == 0)
            {
                return 1;
            }
            return (n * Recursividad(n-1));
        }
    }
    class MainClass
    { 

        public static void Main(string[] args)
        {
            Factorial obj = new Factorial();
            Console.WriteLine("\tCon ciclo for");
            obj.ciclofor();
            Console.Write("\tIntroduce el numero a calcular su factorial mediante recursividad: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(obj.Recursividad(num));
        }
    }
}
