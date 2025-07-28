using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandline
{
    internal class Serialization
    {
      
        static void Main(string[] args)
        {

            string path = @"D:\OneDrive\Desktop\Wipropractise\day5\emply.txt";
            FileStream fr = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fr);
            bw.Write(1);
            bw.Write("pra");
            bw.Write("dev");
            bw.Flush();
            fr.Close();
            Console.WriteLine("primitive datatypes are stored in file sucessfully");
            Console.WriteLine("____________________________________________________");
            FileStream fr1 = new FileStream(path,FileMode.OpenOrCreate, FileAccess.Read);
        
            BinaryReader br = new BinaryReader(fr1);
            int employid = br.ReadInt32();
            string employename = br.ReadString();
            string employetype = br.ReadString();
            Console.WriteLine(employid);
            Console.WriteLine(employename);
            Console.WriteLine(employetype);
            br.Close();
            fr1.Close();

        }
    }
}
