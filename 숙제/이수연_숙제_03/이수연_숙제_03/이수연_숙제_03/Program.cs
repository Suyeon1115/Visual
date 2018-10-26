using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이수연_숙제_03
{
     class Program
     {
          static void Main(string[] args)
          {
               const int a = 5,b =6,c = 7,d = 4,e = 3;
               int Max, Min, Sum=0;

               int[] max = new int[a];
               int[] min = new int[a];
               int[] sum = new int[a];

               int[][] arr = new int[5][];
               arr[0] = new int[a] {-1,3,5,7,9};
               arr[1] = new int[b] {-2,4,8,16,32,64};
               arr[2] = new int[c] {-5,10,15,20,25,30,35};
               arr[3] = new int[d] {-4,8,12,24};
               arr[4] = new int[e] {-10,50,100};

               for (int i = 0; i < 5; i++)
               {
                    max[i] = arr[i][0];
                    min[i] = arr[i][0];
                    sum[i] = 0;

                    for (int j = 0; j < arr[i].Length; j++)
                    {
                         if (max[i] < arr[i][j])
                         {
                              max[i] = arr[i][j];
                         }
                         if (min[i] > arr[i][j])
                         {
                              min[i] = arr[i][j];
                         }
                         sum[i] += arr[i][j];
                    }
                    Console.Write("{0}행의 최소값={1}, 최대값={2}, 합={3}\n", i + 1, min[i], max[i], sum[i]);
               }

               Console.Write("\n");
               Max = max[0];
               Min = min[1];

               for(int k=0; k<5; k++)
               {
                    if(Max<max[k])
                    {
                         Max = max[k];
                    }
                    if (Min > min[k])
                    {
                         Min = min[k];
                    }
                    Sum += sum[k];
               }
               Console.Write("배열의 최소값={0},최대값={1}, 합={2}\n",Min,Max,Sum);
          }
     }
}
