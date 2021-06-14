namespace marathonLibrary
{
    public interface IStartingGroups
    {
        bool Change_CheckDeadline(int marathon_id);
        bool Change_CheckFreeSpaceInStartingGroup(int group_id);
    }
}