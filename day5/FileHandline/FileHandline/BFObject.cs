using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileHandline
{
    internal class BFObject
    {
        static void Main(string[] args)
        {
            EmploySerializer bs = new EmploySerializer();
            bs.employid = 1;
            bs.emplyname = "deepu";
            bs.employtype = "devops";
            string path = @"D:\OneDrive\Desktop\Wipropractise\day5\emplyobj.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,bs);
            fs.Close();
            Console.WriteLine("employee data stored as serializable  object");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("reading sereializable data");
            FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            Console.WriteLine(bf1.Deserialize(fs1));
            


        }
    }
}
