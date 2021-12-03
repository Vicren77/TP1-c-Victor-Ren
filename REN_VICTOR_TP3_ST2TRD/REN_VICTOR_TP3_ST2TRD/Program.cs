using System; 

namespace REN_VICTOR_TP1_ST2TRD
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("exo 1");

            exercice_1 a = new exercice_1();


            a.Multiplication();
            a.Moduleh();
            a.Multiask();
            Console.WriteLine("exo 2");

            exercice_2 b = new exercice_2();
             b.Prime();
            b.Fibonacci();
             b.Factorial();
            Console.WriteLine("for 720 000 it show zero because it is too big");
            exercice_3 c = new exercice_3();

            Console.WriteLine("exo 3");
            c.AttrapeMoisitupeux();
            Console.WriteLine("exo 4");

            exercice_4 d = new exercice_4();
            d.Square();
            Console.WriteLine("exo 5");

            exercice_5 e = new exercice_5();
            e.Tree();
        }
    }
}
