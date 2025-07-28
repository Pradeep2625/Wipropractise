using Agent.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentApplication;
using Agent.Exceptions;
using Agent.Dal;

namespace Agent.Bal
{
    public class AgentBal
    {
        StringBuilder sb = new StringBuilder();
        public static AgentImpl agentdao;
        static AgentBal()
        {
            agentdao = new AgentImpl();
        }
        public string AddAgentBal(AgentModels addagent)
        {
            if(Validations(addagent) == true)
            {
                Console.WriteLine(agentdao.AddAgentDao(addagent));
            }
            throw new Exception(sb.ToString());
        }
        public string UpdateAgentBal(AgentModels updateagent)
        {
            if (Validations(updateagent) == true)
            {
                Console.WriteLine(agentdao.AddAgentDao(updateagent));
            }
            throw new Exception(sb.ToString());

        }
        public List<AgentModels> ShowAgentsBal()
        {
            return agentdao.ShowAgentsDao();
        }
        public string DeleteAgentBal(int agentid)
        {
            return agentdao.DeleteAgentDao(agentid);
        }
        public AgentModels SearchAgentBal(int agentid)
        {
            return agentdao.SearchagentDao(agentid);
        }
        public bool Validations(AgentModels agent)
        {
            bool flag = true;
            //agent = new AgentModels();
            if (agent.AgentId<0)
            {
                sb.Append("agentid must be greater than zero");
                flag = false;
            }
            if (!string.IsNullOrEmpty(agent.FirstName) && agent.FirstName.Length > 10)
            {
                sb.AppendLine("First name length should not exceed 10 characters.");
                flag = false;
            }
            if (agent.PremiumAmount<5000 || agent.PremiumAmount>10000)
            {
                sb.Append("enter amount between 5000 to 10000");
                flag = false;
            }
            if (agent.Gender != 'M' && agent.Gender != 'F')
            {
                sb.Append("Enter gender as if male enter 'M' or if female enter 'F'");
                flag = false;
            }
            return flag;
            
        }
    }
}
