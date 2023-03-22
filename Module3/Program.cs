using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Напишите метод, который отображает квадрат из
некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.*/
namespace Module3
{
    internal class Program
    {
        class DrawSquare
        {
            public void Draw(int size , char symbol)
            {
                for (int i = 0; i < size; i++)
                {

                    for (int j = 0; j < size; j++)
                    {
                        if (i == 0 || j == 0 || i == size-1 || j == size-1) Console.Write(symbol);
                        else Console.Write(' ');
                    } 
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            DrawSquare draw = new DrawSquare();
            char sb = Console.ReadKey().KeyChar;
            Console.WriteLine();
            draw.Draw(5,sb);


        }
    }
}
