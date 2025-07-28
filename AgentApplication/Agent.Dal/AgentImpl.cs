using AgentApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Agent.Dal
{
    public class AgentImpl : IAgentdao
    {
        static int count = 1;
        static List<AgentModels> agentlist;
        static AgentImpl()
        {
            agentlist = new List<AgentModels>();
        }
        public string AddAgentDao(AgentModels addagent)
        {
                
                addagent.AgentId = count++;
                agentlist.Add(addagent);
                
                return "employ added successfully";
   
        }

        public string DeleteAgentDao(int agentid)
        {
            AgentModels agentfound = SearchagentDao(agentid);
            if (agentfound != null)
            {
                agentlist.Remove(agentfound);
            }
            return "agent deleted successfulyy....";
        }

        public AgentModels SearchagentDao(int id)
        {
            AgentModels agentfound = null;
            foreach(AgentModels agent in agentlist)
            {
                if(agent.AgentId == id)
                {
                    agentfound = agent; 
                    break;
                }
                
            }
            return agentfound;
        }

        public List<AgentModels> ShowAgentsDao()
        {
            return agentlist;
        }

        public string UpdateAgentDao(AgentModels updateagent)
        {
            AgentModels agent = SearchagentDao(updateagent.AgentId);
            if (agent != null)
            {
                agent.AgentId = updateagent.AgentId;
                agent.FirstName = updateagent.FirstName;
                agent.LastName = updateagent.LastName;
                agent.Gender = updateagent.Gender;
                agent.City = updateagent.City;
                agent.PremiumAmount = updateagent.PremiumAmount;
            }
            return "agent updated successfully";
        }
    }
}
