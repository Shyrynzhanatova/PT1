using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student 
    {
        public string name; // комплексное число
        public string surname;
        public double gpa;

        public Student (string _name, string _surname, double _gpa)
        {
            this.name = _name;//передаем параметры
            this.surname = _surname;
            this.gpa = _gpa;
        }
       
        public override string ToString()// метод конструктор для принятия начального значения
        {
            return name + " " + surname + " " + gpa;//возвращаем данные(имя, фамилию и джипиэй)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            Double gpa = Convert.ToDouble(Console.ReadLine());// стринг ту дабл
            Student inf = new Student(name, surname, gpa);
            Console.WriteLine(inf);
            Console.ReadKey();
        }
    }
}