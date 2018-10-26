using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이수연_0918
{
     
     class Program
     {
          static void Main(string[] args)
          {
               int a, b;
               string yesno;

               Arithmetic1 c1 = new Arithmetic1();

               ArithmeticDelegate d1 = new ArithmeticDelegate(c1.Add);
               ArithmeticDelegate d2 = new ArithmeticDelegate(c1.Sub);
               ArithmeticDelegate d3 = new ArithmeticDelegate(c1.Mul);
               ArithmeticDelegate d4 = new ArithmeticDelegate(c1.Div);

               d1 += d2;
               d1 += d3;
               d1 += d4;

               while(true)
               {
                    Console.Write("첫번째 수:");
                    a = Int32.Parse(Console.ReadLine());
                    Console.Write("두번째 수:");
                    b = Int32.Parse(Console.ReadLine());

                    d1(a, b);

                    Console.Write("\n");
                    Console.Write("계속 입력(y), 중지(n):");
                    yesno = Console.ReadLine();
                    if (yesno == "n") break;
                    
               }
          }
     }
}
