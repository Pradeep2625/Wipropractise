using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication
{
    public class AgentModels
    {
      public  int AgentId { get; set; }
      public  string FirstName { get; set; }
       public string LastName { get; set; }
        public string City { get; set; }
        public char Gender { get; set; }
        public double PremiumAmount { get; set; }
        public AgentModels() { }
        public AgentModels(int agentid, string firstname, string lastname,
            string city, char gender, double premiumamount)
        {
            AgentId = agentid;
            FirstName = firstname;
            LastName = lastname;
            City = city;
            Gender = gender;
            PremiumAmount = premiumamount;

        }
        public override string ToString()
        {
            return $"Agent Id: {AgentId}"+" "+
                $"FullName: {FirstName}  {LastName}"+" "+
                $"City: {City}"+" "+
                $"Gender: {Gender}"+" "+
                $"Premiumamount: {PremiumAmount}";


        }


    }
}
