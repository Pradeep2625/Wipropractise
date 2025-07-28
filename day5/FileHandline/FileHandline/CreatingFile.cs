using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandline
{
    internal class CreatingFile
    {
        public void FileReader()
        {
            string path = @"D:\OneDrive\Desktop\Wipropractise\day5\demo.txt";
            FileStream fs = new FileStream(path, FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("hello user welcome to file handling");
            sw.Flush();
            fs.Close();
        }
        static void Main(string[] args)
        {
            CreatingFile cf = new CreatingFile();
            cf.FileReader();
            Console.WriteLine("file created succesfully with given content");
        }
    }
}
