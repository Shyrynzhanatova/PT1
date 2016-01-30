using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Complex
    {
        public int a, b; // комплексное число
        public Complex (int a, int b)
        {
            this.a = a;//передаем параметры
            this.b = b;
        }
        public static Complex operator +(Complex c1, Complex c2) //суммирование с оператором +
        {
            Complex sum = new Complex(c1.a + c2.a, c2.b + c2.b); //само число
            return sum;
        }
        public override string ToString()// с базовой билиотеки переводим в наш комплекс
        {
            return a + "/" + b;//возвращаем
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4; //создаем переменные 
            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());
            n4 = Int32.Parse(Console.ReadLine());
            Complex first_complex = new Complex(n1, n2);//передаем переменные классу
            Complex second_complex = new Complex(n1, n2);
            Complex sum = first_complex + second_complex;//вызываем оператор +
        }
    }
}