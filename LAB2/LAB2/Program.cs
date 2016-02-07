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
            FileInfo file = new FileInfo("C:\\Users\\Shyryn\\Desktop");
            if (file.Exists)
            {
                Console.WriteLine("File name {0}, file fullname {1}", file.Name, file.FullName);
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}
