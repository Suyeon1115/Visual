//n개의 값을 입력 한 후 최대값 최소값을 출력하는 프로그램 
using System;

namespace 이수연_05
{
    class Program
    {
        static void Main(string[] args)
        {
               while (true)
               {
                    int n, i, max, min;

                    Console.Write("\n");
                    Console.Write("n값을 입력:");//입력할 데이터 수를 n로 입력 
                    n = Int32.Parse(Console.ReadLine());//n개 값을 저장할 수 배열객체 생성  
                    Console.Write("\n");

                    int[] arr = new int[n];

                    for (i = 0; i < arr.Length; i++)
                    {
                         Console.Write("{0}번째 값을 입력:", i + 1);
                         arr[i] = Int32.Parse(Console.ReadLine());//키보드 입력을 받아 배열에 저장 

                    }

                    max = arr[0];
                    min = arr[0];

                    for (i = 0; i < arr.Length; i++)
                    {
                         if (max < arr[i])
                         {
                              max = arr[i];
                         }
                         if (min > arr[i])
                         {
                              min = arr[i];
                         }
                    }

                    Console.Write("최대값: {0}:, 최소값:{1}", max, min);
                    Console.Write("\n");

               }
               
          }
    }
}
