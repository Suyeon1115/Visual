using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 이수연13
{
     class IndexerExample
     {
          private int size;
          public ADDR_CARD[] Iname;
          public ADDR_CARD this[int index]
          {
               get {
                    if(index > -1 && index<size)
                    {
                         return Iname[index];
                    }
                    else
                    {
                         Console.WriteLine("인덱스 오류!!!");
                         return null;
                    }     
               }
               set {
                    if (index > -1 && index < size)
                    {
                         Iname[index] = value;
                    }
                    else { Console.WriteLine("인덱스 오류!!!"); }
               }
          }

          public IndexerExample(int card_size)
          {
               size = card_size;
               Iname = new ADDR_CARD[size];
          }
     }
}
