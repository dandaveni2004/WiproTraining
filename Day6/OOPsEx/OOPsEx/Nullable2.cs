using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class Nullable2
    {
        static void Main()
        {
            Agent agent1 = new Agent();
            agent1.AgentId = 101;
            agent1.AgentName = "Nanii";

            agent1.Status = agent1.BusinessAmount ?? 0;

            Console.WriteLine(agent1);


            Agent agent2 = new Agent();
            agent2.AgentId = 102;
            agent2.AgentName = "Paradise";
            agent2.BusinessAmount = 9999999;

            agent2.Status = agent2.BusinessAmount ?? 0;

            Console.WriteLine(agent2);

        }
    }
}
