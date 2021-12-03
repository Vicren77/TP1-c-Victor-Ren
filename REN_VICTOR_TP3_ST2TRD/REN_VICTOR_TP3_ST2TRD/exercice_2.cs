using System;
using System.Collections.Generic;
using System.Text;

namespace REN_VICTOR_TP1_ST2TRD
{
    class exercice_2
    {
        public  void Prime()
        {
            
            for(var i=2;i<1001;i++)
            {
                bool optimusprime = true;

                for (var j=2;j<i;j++ )
                {
                    if(i%j==0)
                    {
                        optimusprime = false;
                        break;
                    }
                }
                if(optimusprime)
                {
                    Console.WriteLine(i + " ");
                }
            }
             
        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter le nombre pour fibonacci :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public void  Fibonacci()
        {
            int n = AskUserForParameter();
            int[] f = new int[n + 2];
            int i;
            f[0] = 0;
            f[1] = 1;
            //Console.WriteLine("hello zbi");
            for (i = 2; i <= n; i++)
             {
                
                f[i] = f[i - 1] + f[i - 2];
            }
           // Console.WriteLine("hello zbi");
            Console.WriteLine(f[n]); 
           
        }
        public void Factorial()
        {
            int n = AskUserForParameter();

            int i, fact = 1;
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + n + " is: " + fact + "\n");
        }
      



    }
}
