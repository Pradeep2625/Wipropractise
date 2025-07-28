using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentApplication;
namespace Agent.Dal
{
    internal interface IAgentdao
    {
        string AddAgentDao(AgentModels addagent);
        List<AgentModels> ShowAgentsDao();
        AgentModels SearchagentDao(int id);

        string DeleteAgentDao(int agentid);
        string UpdateAgentDao(AgentModels updateagent);
    }
}
