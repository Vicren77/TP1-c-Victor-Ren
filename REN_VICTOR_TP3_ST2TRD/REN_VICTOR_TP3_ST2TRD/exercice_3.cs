using System;
using System.Collections.Generic;
using System.Text;

namespace REN_VICTOR_TP1_ST2TRD
{
    class exercice_3
    {

        public void AttrapeMoisitupeux()
        {
            for(int i = -3;i<4;i++)
            {
                try
                {
                    
                    int y=PowerFunction(i);
                    int x = 10 / y;
                    Console.WriteLine(x);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }
    }
}
