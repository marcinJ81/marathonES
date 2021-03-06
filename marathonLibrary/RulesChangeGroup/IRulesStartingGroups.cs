namespace marathonLibrary
{
    public interface IRulesStartingGroups
    {
        bool Change_CheckDeadline(int marathon_id);
        bool Change_CheckFreeSpaceInStartingGroup(int group_id);
        bool Change_CheckHistoryChangeGroupFoParticipant(int participantId);
        bool Change_CheckDistanceOfTargetGroup(int sourceGroup, int targetGroup);
        bool Change_CheckGenerateGroups(int marathon_id);
    }
}