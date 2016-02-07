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
            FileStream f1 = new FileStream(@"C:\Users\Shyryn\Desktop\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream f2 = new FileStream(@"C:\Users\Shyryn\Desktop\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(f1);
            StreamWriter sw = new StreamWriter(f2);

            string[] s = sr.ReadLine().Split();
            int a;
            List<int> primes = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                a = int.Parse(s[i]);
                int cnt = 0;

                for (int j = 1; j <= a; j++)
                {
                    if (a % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt < 3)
                {
                    primes.Add(a);
                }
            }
     
            sw.WriteLine("Min prime number = {0}", primes.Min()); 
            
            sr.Close();
            sw.Close();
            f2.Close();
            f1.Close();

            Console.ReadKey();
        }
    }
}


