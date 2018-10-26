using System;

namespace 이수연_숙제_02
{
    class Program
    {
        static void Main(string[] args)
        {
            
               int i,j,k= 0;

               for(i=2;i<=9;i++)
               {
                    Console.Write("{0}단", i);
                    Console.Write("           ");
               }

               Console.Write("\n");
               for(k=1; k<=9; k++)
               {
                    for (j = 2; j <= 9; j++)
                    {
                         Console.Write("{0}*{1}={2,-10}", j, k, j*k);
                        
                    }
                    Console.WriteLine();
               }
               /*
               Console.Write("\n\n\n");
               for (i = 2; i <= 9; i++)
               {
                    Console.Write(i+"단"+"\t"+"\t");
                    
               }
               Console.Write("\n");
               for (k = 1; k <= 9; k++)
               {
                    for (j = 2; j <= 9; j++)
                    {
                         Console.Write(j+"*"+k+"="+j*k+"\t");
                         Console.Write("\t");
                    
                         

                    }
                    Console.WriteLine();
               }
               */

          }
    }
}
