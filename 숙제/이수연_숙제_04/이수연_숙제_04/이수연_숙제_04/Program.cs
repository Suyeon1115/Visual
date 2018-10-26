using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이수연_숙제_04
{
     class Program
     {
          static void Main(string[] args)
          {
               int menu;
               string NAME;
               ADD_CARD card;
               ArrayList al = new ArrayList();

               while(true)
               {
                    Console.WriteLine("\n메뉴 1.입력 2.검색 3.종료");
                    Console.Write("메뉴를 선택하시요:");
                    menu = Int32.Parse(Console.ReadLine());
                    switch(menu)
                    {
                         case 1:
                              card = new ADD_CARD();
                              Console.Write("이름:");
                              card.Name = Console.ReadLine();
                              Console.Write("주소:");
                              card.Address = Console.ReadLine();
                              Console.Write("전화:");
                              card.Phone = Console.ReadLine();
                              al.Add(card);//ArrayList에 삽입
                              break;

                         case 2:
                              Console.Write("검색할 이름을 입력하시요.:");
                              NAME = Console.ReadLine();
                              bool find = false;
                        
                              foreach (ADD_CARD n in al)
                              {
                                   if (n.Name == NAME)
                                   {
                                        Console.Write("이름: {0}\t", n.Name);
                                        Console.Write("주소: {0}\t", n.Address);
                                        Console.Write("전화: {0}\t", n.Phone);
                                        Console.Write("\n");
                                        find = true;
                                        break;
                                   }
                              }  
                              if(find == false)
                              {
                                   Console.Write("{0}은 없습니다.\n", NAME);
                              }
                              break;
                    
                         case 3: return;

                    }
               }
          }
     }
}
