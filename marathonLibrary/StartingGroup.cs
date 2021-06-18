using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathonLibrary
{
    public class StartingGroup : IStartingGroup
    {
        private IRulesStartingGroups rulesStartingGroups;
        private IDomainResult domainResult;
        private int GroupId;
        public StartingGroup(
            IRulesStartingGroups rulesStartingGroups,
            IDomainResult domainResult,
            int groupId)
        {
            this.rulesStartingGroups = rulesStartingGroups;
            this.domainResult = domainResult;
            this.GroupId = groupId;
        }

        public IDomainResult Change(
            int marathonId,
            int targetGroupId,
            int participantId
            )
        {
            if (!rulesStartingGroups.Change_CheckGenerateGroups(marathonId))
            {
                return domainResult.StartingGroupHasNotChange();
            }
            if (!rulesStartingGroups.Change_CheckDistanceOfTargetGroup(this.GroupId, targetGroupId))
            {
                return domainResult.StartingGroupHasNotChange();
            }
            if (!rulesStartingGroups.Change_CheckDeadline(marathonId))
            {
                return domainResult.StartingGroupHasNotChange();
            }
            if (!rulesStartingGroups.Change_CheckFreeSpaceInStartingGroup(targetGroupId))
            {
                return domainResult.StartingGroupHasNotChange();
            }
            if (!rulesStartingGroups.Change_CheckHistoryChangeGroupFoParticipant(participantId))
            {
                return domainResult.StartingGroupHasNotChange();
            }
            return domainResult.StartingGroupHasChange();
        }
    }
}
