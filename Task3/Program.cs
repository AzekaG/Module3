using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Напишите метод, фильтрующий массив на основании
переданных параметров. Метод принимает параметры:
оригинальный_массив, массив_с_данными_для_фильтрации.
ДОМАШНЕЕ ЗАДАНИЕ
1
Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
Например:
1 2 6 -1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 -1 — результат работы метода*/

namespace Task3
{
    internal class Program
    {
        class FilterArray
        {

            public void Filter(ref int[] arrMain, int[] arrFilter)
            {
                int[] arrTemp = new int[arrMain.Length];

                int k = 0;
                for (int i = 0; i < arrTemp.Length; i++)
                {
                    for (int j = 0; j < arrFilter.Length; j++)
                    {
                        if (arrMain[i] == arrFilter[j]) break;
                        if (j == arrFilter.Length - 1)
                        {
                            arrTemp[k++] = arrMain[i];
                        }

                    }

                }
                arrMain = new int[k];

                for (int i = 0; i < k; i++)
                {
                    arrMain[i] = arrTemp[i];
                    
                }
                


            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 4, 2, 9 };
            FilterArray filterArray = new FilterArray();
            filterArray.Filter(ref arr, arr2);

            foreach (int i in arr) 
            {
            Console.WriteLine(i);
            }
        }
    }
}
