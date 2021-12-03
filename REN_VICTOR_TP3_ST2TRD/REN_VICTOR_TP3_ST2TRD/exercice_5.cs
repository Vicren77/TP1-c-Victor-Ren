using System;
using System.Collections.Generic;
using System.Text;

namespace REN_VICTOR_TP1_ST2TRD
{
    class exercice_5
    {
        public void Tree()
        {
            int space = AskUserForParameter();
            int superman = space;
            int a = 1;
            int b = 1;
            for (int i = 0; i < superman; i++)
            {
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < a; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                a++;
                space--;
            }
            for (int j = 0; j < superman; j++)
            {
                Console.Write(" ");
                if (j == superman - 2)
                {
                    { Console.WriteLine("| |"); }

                }


            }
        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number between 3 and 20 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }


    }
}
