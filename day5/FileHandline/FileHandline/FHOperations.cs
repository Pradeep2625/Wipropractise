using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandline
{
    
    internal class FHOperations
    {
        string path;
        public void AddingDataToExst()
        {
            path = @"D:\OneDrive\Desktop\Wipropractise\day5\demo.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("appending the data");
            sw.Flush();
            fs.Close();
        }

        public void RemoveingDataFromExst()
        {

            path = @"D:\OneDrive\Desktop\Wipropractise\day5\demo.txt";
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite);
            Console.WriteLine("cleared all data....");
        }
        public void OpenOrCreate()
        {
            path = @"D:\OneDrive\Desktop\Wipropractise\day5\demo1.txt";
            bool fileexist = File.Exists(path);
            
            if (fileexist)
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadLine());
            }
            else
            {
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("new file created because given file not found");
                sw.Flush();
                fs.Close();

            }
        }
        static void Main(string[] args)
        {

            FHOperations fho = new FHOperations();
            FHOperations fho1 = new FHOperations();
            fho.AddingDataToExst();
            fho.RemoveingDataFromExst();
            fho.OpenOrCreate();
            fho1.OpenOrCreate();

        }
    }
}
