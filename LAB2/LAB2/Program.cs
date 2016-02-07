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
        public static void DirectoryTree(string path)
        {
            Stack<string> st = new Stack<string>();
            Console.WriteLine(path + ":" + Directory.GetFiles(path).Length);
            st.Push(path);

            while (st.Count > 0)
            {
                string[] subdirs = Directory.GetDirectories(st.Pop());
                foreach (string s in subdirs)
                {
                    Console.WriteLine(path + ":" + Directory.GetFiles(s).Length);
                    st.Push(s);
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryTree(@"C:\Users\Shyryn\Desktop\Олжик");
        }
    }
}


