using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FilterException
    {
        public static void Severity(string severity)
        {
            if(severity == "low")
            {
                throw new UserDefinedexh("priority level is low");
            }else if(severity =="medium"){
                throw new UserDefinedexh("priority level is medium");
            } else if(severity =="high")
            {
                throw new UserDefinedexh("priority level is high check it immediately");
            } else if(severity =="critical")
            {
                throw new UserDefinedexh("priority level is very high please check it immediately asap!!");
            }
            else
            {
                throw new UserDefinedexh("no severity found");
            }
        }
        static void Main (string[] args)
        {
           
            Console.Write("enter severity level (low/medium/high/critical): ");
            string severity = Console.ReadLine().ToLower();
            try
            {
                Severity(severity);
            }
            catch(UserDefinedexh e) when (severity=="low")
            {

                Console.WriteLine(e.Message); ;
            }
            catch (UserDefinedexh e) when (severity=="medium")
            {

                Console.WriteLine(e.Message); ;
            }
            catch (UserDefinedexh e) when (severity=="high")
            {

                Console.WriteLine(e.Message); ;
            }
            catch (UserDefinedexh e) when (severity=="critical")
            {

                Console.WriteLine(e.Message); ;
            }
        }
    }
}
