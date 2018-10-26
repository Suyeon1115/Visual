using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이수연13
{
     class Program
     {
          static void Main(string[] args)
          {
               IndexerExample sid = new IndexerExample(5);
               ADDR_CARD ob1;
               int i = 0;
               string yesno;
               while (true)
               {
                    ob1 = new ADDR_CARD();
                    Console.Write("이름: ");
                    ob1.Name = Console.ReadLine();
                    Console.Write("주소: ");
                    ob1.Address = Console.ReadLine();
                    Console.Write("전화: ");
                    ob1.Phone = Console.ReadLine();

                    sid[i++] = ob1;
                    Console.Write("계속(Y) 종료(n):");
                    yesno = Console.ReadLine();
                    if (yesno == "y") continue;
                    else break;
               }
               for (int j = 0; j < i; j++)
                    Console.WriteLine("이름:{0}\t주소:{1}\t전화번호:{2}",sid[j].Name, sid[j].Address, sid[j].Phone);
          }
     }
}
