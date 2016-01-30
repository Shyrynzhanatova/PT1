using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(); 
            //тукен нужен для того чтобы разделить заданный набор чисел (по пробелу)
            for (int i = 0; i < token.Length; i++) //пробегаемся по числам 
            {
                int cnt = 0; //счетчик делителей
                int a = int.Parse(token[i]); // интпарс переводит стринг в строку 
                for (int j = 1; j <= a; j++) //пробегаемся по делителям 
                {
                    if (a % j == 0) //если заданное число делится на какое то число, то счетчик снт увеличивается
                    {
                        cnt++; //счетчик увеличиватся на 1
                    }
                }
                if (cnt < 3) //число делителей не должно быть больше 2
                {
                    Console.Write("{0} ", a); //выводим это число
                }
            }
            Console.ReadKey();
        }
    }
}