using System;
using System.Collections.Generic;
using System.Text;

namespace REN_VICTOR_TP1_ST2TRD
{
    class exercice_4
    {

        private static int AskUserForParameter()
        {
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        public void Square()
        {
            Console.WriteLine("Please input the N then the M");
           
            int N = AskUserForParameter();
            int M = AskUserForParameter();
            string Nem = "|";
            string men = "-";

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < M; j++)
                {
                    if(j ==0 || j == M - 1)
                    {
                        { Console.Write("|"); }

                    }
                    else if (i == 0 || i == N - 1)

                    { Console.Write("-"); }
                    
                    /*  else if( i ==0 || j == 0)
                      {
                          Console.WriteLine("a");
                      }*/
                    else
                    { Console.Write(" "); }
                }
                //Console.WriteLine("|");

            }



        }


    }

}
