using System.Collections.Generic;

namespace marathonLibrary.Groups
{
    public interface IMarathonGroups
    {
        int CheckGroupFreeSpace(int groupId);
        int GetDistanceFromGroup(int groupId);
        public MarathonGroup GetMarathonGroup(int groupId);
        public List<MarathonGroup> marathonGroups();
    }

    public class MarathonGroups : IMarathonGroups
    {
        public int CheckGroupFreeSpace(int groupId)
        {
            throw new System.NotImplementedException();
        }

        public int GetDistanceFromGroup(int groupId)
        {
            throw new System.NotImplementedException();
        }

        public MarathonGroup GetMarathonGroup(int groupId)
        {
            throw new System.NotImplementedException();
        }

        public List<MarathonGroup> marathonGroups()
        {
            throw new System.NotImplementedException();
        }
    }
}