using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    internal static class Exmpl1
    {
        static int logscount;
        static void PrintLogs()
        {

            Console.WriteLine("\"INFO: [timestamp] - message\"");
            logscount++;
        }
        static void Main(string[] args)
        {
            Exmpl1.PrintLogs();
            Exmpl1.PrintLogs();
            Exmpl1.PrintLogs();
            Exmpl1.PrintLogs();
            Exmpl1.PrintLogs();
            Exmpl1.PrintLogs();
            Console.WriteLine(Exmpl1.logscount); 
        }
    }
}
