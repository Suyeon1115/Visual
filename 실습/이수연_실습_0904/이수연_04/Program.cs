using System;

namespace 이수연_04
{
    class Program
    {
        static void Main(string[] args)
        {
               int linecnt;
               linecnt = 0;

               Console.WriteLine("3의 배수");
               int i=1;
               do
               {
                    if (i % 3 == 0)
                    {
                         Console.Write("{0,4}", i);
                         linecnt = linecnt + 1;
                         
                    }
                    if (linecnt == 4)
                    {
                         linecnt = 0;
                         Console.WriteLine();
                    }
                    i++;
               } while (i <= 100);

               Console.WriteLine("\n");
               Console.WriteLine("4의 배수");
               linecnt = 0;
               for (i = 1; i <= 100; i++)
               {
                    
                    if (i % 4 == 0)
                    {
                         Console.Write("{0,4}", i);
                         linecnt = linecnt + 1;

                    }
                    if (linecnt == 4)
                    {
                         linecnt = 0;
                         Console.WriteLine();
                    }
               }

               Console.WriteLine("\n");
               Console.WriteLine("5의 배수");
               linecnt = 0;
               i = 1;
               while(i<=100)
               {
                    if (i % 5 == 0)
                    {
                         Console.Write("{0,4}", i);
                         linecnt = linecnt + 1;
                         

                    }

                    if (linecnt == 4)
                    {
                         linecnt = 0;
                         Console.WriteLine();
                    }
                    i++;
               }
          }

    }
}
