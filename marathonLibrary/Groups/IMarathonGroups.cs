using System.Collections.Generic;

namespace marathonLibrary.Groups
{
    public interface IMarathonGroups
    {
        int CheckGroupFreeSpace(int id);
        List<MarathonGroups> GetDistanceFromGroup(int groupId);
    }
}