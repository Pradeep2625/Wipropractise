using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandline
{
    internal class FileReader
    {
        public void Readingfile()
        {
            string path = @"D:\OneDrive\Desktop\Wipropractise\day5\demo.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            

            Console.WriteLine(sr.ReadLine());
            sr.Close();
        }
        static void Main(string[] args)
        {
            FileReader fr = new FileReader();
            fr.Readingfile();
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("the data present in file succesfull printed in console");
        }
    }
}
