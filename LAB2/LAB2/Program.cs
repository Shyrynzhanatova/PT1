using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream(@"C:\Users\Shyryn\Desktop\Shyrynin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream f2 = new FileStream(@"C:\Users\Shyryn\Desktop\Shyrynout", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamReader sr = new StreamReader(f1);
            StreamWriter sw = new StreamWriter(f2);

            string[] s = sr.ReadLine().Split();
            long min, max;
            min = long.Parse(s[0]);
            max = long.Parse(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                long a = long.Parse(s[i]);

                if (min >= a)
                {
                    min = a;
                }
                if (max <= a)
                {
                    max = a;
                }
            }
            Console.WriteLine("min = {0}, max = {1}", min, max);


            sr.Close();
            sw.Close();
            f1.Close();
            f2.Close();
            Console.ReadKey();
        }
    }
}


