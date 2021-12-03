using System;
using System.Collections.Generic;
using System.Text;

namespace REN_VICTOR_TP1_ST2TRD
{
    class exercice_1
    {
       
        int n =1;
        int f = 1;
        public void  Multiplication()
        {

            for (int j = 1; j< 11; j++)
            {
                
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(i * n);             
                    //Console.WriteLine(InchAllahMonPote(i));
                }
                n++;
            }
        }
     
        public void Moduleh()
        {
            for (int j = 1; j < 11; j++)
            {

                for (int i = 1; i < 11; i++)
                {
                    //Console.WriteLine(InchAllahMonPote(i));
                    if ((i*f) % 2 != 0)
                    {
                        Console.WriteLine(i*f);
                    }

                }
                f++;
            }
        }
        public void Multiask()
        {
            n = AskUserForParameter();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * n);
                //Console.WriteLine(InchAllahMonPote(i));
            }
           

        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter la multiplcation :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }


    }
}
