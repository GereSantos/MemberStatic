using System;

namespace MemberStaticExercise
{
    internal class Program
    {
        //Utilizando Membros estáticos para criar função de operações matématicas
        static void Main(string[] args)
        {
            Console.WriteLine("N1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("N2");
            int n2 = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Sum " + sum(n1, n2));
            Console.WriteLine("Sub  " + sub(n1,n2));
            Console.WriteLine("Mult " + multiplier(n1,n2));
            Console.WriteLine("Div " + division(n1,n2));
        }

        static int sum(int n1,int n2)
        {
            return n1 + n2;
        }

        static int sub(int n1, int n2)
        {
            return n1 - n2;
        }

        static int multiplier(int n1,int n2)
        {
            return n1 * n2;
        }

        static int division(int n1,int n2)
        {
            return n1 / n2;
        }
    }
}
