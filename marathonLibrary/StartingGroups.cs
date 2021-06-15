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
        private IChangeGroupHistory changeGroupHistoryList;

        public StartingGroups(
            IMarathonConfiguration marathonConfiguration,
            IMarathonGroups marathonGroups,
            IChangeGroupHistory listChangeGroup)
        {
            this.marathonConfiguration = marathonConfiguration;
            this.marathonGroups = marathonGroups;
            this.changeGroupHistoryList = listChangeGroup;
        }

        public bool Change_CheckDeadline(int marathon_id)
        {
           DateTime DeadLineDate =  marathonConfiguration.GetGroupChangeDeadline(marathon_id);
           if(DateTime.Now > DeadLineDate)
                return false;
           return true;
        }

        public bool Change_CheckFreeSpaceInStartingGroup(int group_id)
        {
           int freeSpace = marathonGroups.CheckGroupFreeSpace(group_id);
            if (freeSpace > 0)
                return true;
            else
                return false;
        }

        public bool Change_CheckHistoryChangeGroupFoParticipant(int participantId)
        {
             return !changeGroupHistoryList.GetListOfChangeGroup(participantId).Any();
        }

        public bool Change_CheckDistanceOfTargetGroup(int idSourceGroup, int idTargetGroup)
        {
            if( marathonGroups.GetDistanceFromGroup(idSourceGroup) == marathonGroups.GetDistanceFromGroup(idTargetGroup))
                return true;
            return false;  
        }

        public bool Change_CheckGenerateGroups(int marathon_id)
        {
            return marathonGroups.marathonGroupsIsGenerated(marathon_id).Any(); 
        }
    }
}
