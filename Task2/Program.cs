using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/*Напишите метод, который проверяет является ли
переданное число «палиндромом». Число передаётся в
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.*/
namespace Task2
{
    internal class Program
    {
        class Pallindrom
        {
            public bool PallindromCheck(int value)
            {
                int count = 0 , temp = value;
                for (; temp > 0; count++)
                   temp /= 10;

                temp = value;
                int[] array = new int[count];
                for (int i = 0 ;temp > 0;i++ )
                {
                    array[i] = temp % 10;
                    temp /= 10;
                }
                
                for (int i = 0, j = count - 1; i < count / 2; i++, j--)
                { if (array[i] != array[j]) return false; } 
                return true;
            }
            
        }
        static void Main(string[] args)
        {
            
            Pallindrom p = new Pallindrom();
            Console.WriteLine("Enter a value");
            int value = int.Parse(Console.ReadLine());
           
            Console.WriteLine(p.PallindromCheck(value));
        }
    }
}
