using AgentApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agent.Bal;
using Agent.Dal;
using Agent.Exceptions;
namespace Agent.Main
{
    internal class Program
    {
        static AgentBal agentBal;
        static Program()
        {
            agentBal = new AgentBal();
        }
        public static void AddAgentMain()
        {
            AgentModels am = new AgentModels();
            Console.WriteLine("Enter Agent Details:");
            //Console.WriteLine("Enter Agent Id: ");
            //int agentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Agent First Name :");
            am.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Agent Last Name: ");
            am.LastName = Console.ReadLine();
            Console.WriteLine("Enter Gender ('M' or 'F'): ");
            am.Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter City: ");
            am.City = Console.ReadLine();
            Console.WriteLine("enter premium amount/month: ");
            am.PremiumAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(agentBal.AddAgentBal(am));
        }
        public static void UpdateAgentMain()
        {
            AgentModels uam = new AgentModels();
            Console.WriteLine("Enter Agent Details:");
            //Console.WriteLine("Enter Agent Id: ");
            //int agentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Agent First Name :");
            uam.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Agent Last Name: ");
            uam.LastName = Console.ReadLine();
            Console.WriteLine("Enter Gender ('M' or 'F'): ");
            uam.Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter City: ");
            uam.City = Console.ReadLine();
            Console.WriteLine("enter premium amount/month: ");
            uam.PremiumAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(agentBal.UpdateAgentBal(uam));
        }
        public static void ShowAgentsMain()
        {
            List<AgentModels> list = agentBal.ShowAgentsBal();
            Console.WriteLine("agent record found:");
            foreach(AgentModels show in list)
            {
                Console.WriteLine(show);
            }
             
        }
        public static void SearchAgentMain()
        {
            Console.WriteLine("Enter Agent Id: ");
            int agentid = Convert.ToInt32(Console.ReadLine());
            AgentModels am = agentBal.SearchAgentBal(agentid);
            if (am!=null)
            {
                Console.WriteLine(am);
            }else
            {
                Console.WriteLine("agent record not found");
            }
        }
        public static void DeleteAgentMain()
        {
            Console.WriteLine("Enter Agent Id: ");
            int agentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(agentBal.DeleteAgentBal(agentid));
        }
        static void Main(string[] args)
        {
            int choice;
            
            do
            {
                
                Console.WriteLine("select an Option:___ ");
                Console.WriteLine("1.Add Agent");
                Console.WriteLine("2.Show Agents");
                Console.WriteLine("3.Update Agent");
                Console.WriteLine("4.Delete Agent");
                Console.WriteLine("5.select Agent By id");
                Console.WriteLine("select choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddAgentMain();
                        }
                        catch (AgentExceptions e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        ShowAgentsMain();
                        break;
                    case 3:
                        try
                        {
                            UpdateAgentMain();
                        }
                        catch (AgentExceptions e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        
                        break;
                    case 4:
                        DeleteAgentMain();
                        break;
                    case 5:
                        SearchAgentMain();
                        break;

                }
            }
            while (choice != 8);
                
            

        }
    }
}
