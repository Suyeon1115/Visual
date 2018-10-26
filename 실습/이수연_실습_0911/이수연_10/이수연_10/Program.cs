using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이수연_10
{
     class Program
     {
          static void Main(string[] args)
          {
               ArrayList al = new ArrayList();// 참조 배열 생성
               ADDR_CARD card;
               string yesno;
               
               while(true)//입력
               {
                    card = new ADDR_CARD();//객체 생성
                    Console.Write("이름:");
                    card.Name = Console.ReadLine();
                    Console.Write("주소:");
                    card.Addres = Console.ReadLine();
                    Console.Write("전화:");
                    card.Phone = Console.ReadLine();

                    al.Add(card);//ArrayList에 삽입
                    Console.Write("\n계속 입력(y),중지(n):");
                    yesno = Console.ReadLine();
                    if (yesno == "n") break;
               }
               foreach(ADDR_CARD n in al)
               {
                    Console.Write("\n");
                    Console.Write("이름: {0}\t",n.Name);
                    Console.Write("주소: {0}\t",n.Addres);
                    Console.Write("전화: {0}\t",n.Phone);
                    Console.Write("\n");
               }
          }
     }
}
