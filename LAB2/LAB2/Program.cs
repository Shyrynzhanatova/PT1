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
        public static void WalkDirectoryTree(DirectoryInfo d, int depth)
        {
            try
            {
                foreach (FileInfo file in d.GetFiles())
                {
                    Console.WriteLine("Depth={0}, File={1}", depth, file.Name);
                }
                foreach (DirectoryInfo di in d.GetDirectories())
                {
                    Console.WriteLine("Depth={0}, File={1}", depth, di.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"c:\windows");
            WalkDirectoryTree(d, 0);
            Console.ReadKey();
        }
    }
}
