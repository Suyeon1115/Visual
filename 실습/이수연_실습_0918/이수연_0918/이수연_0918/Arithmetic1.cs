using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이수연_0918
{
     public delegate void ArithmeticDelegate(int x, int y);

     class Arithmetic1
     {
          public void Add(int x,int y)
          {
               Console.WriteLine("두수의 합:{0}",x+y);
          }
          public void Sub(int x, int y)
          {
               Console.WriteLine("두수의 차:{0}", x - y);
          }
          public void Mul(int x, int y)
          {
               Console.WriteLine("두수의 곱:{0}", x * y);
          }
          public void Div(int x, int y)
          {
               Console.WriteLine("두수의 나누기:{0}", x / y);
          }

     }
}
