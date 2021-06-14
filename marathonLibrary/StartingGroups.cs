using marathonLibrary.Configuration;
using marathonLibrary.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathonLibrary
{
    public class StartingGroups : IStartingGroups
    {
        private IMarathonConfiguration marathonConfiguration;
        private IMarathonGroups marathonGroups;

        public StartingGroups(IMarathonConfiguration marathonConfiguration, IMarathonGroups marathonGroups)
        {
            this.marathonConfiguration = marathonConfiguration;
            this.marathonGroups = marathonGroups;
        }

        public bool Change_CheckDeadline(int marathon_id)
        {
           DateTime DeadLineDate =  marathonConfiguration.GetGroupChangeDeadline(marathon_id);
           if(DateTime.Now > DeadLineDate)
                return false;
           return true;
        }
    }
}
