using marathonLibrary.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Marathon.FakeDependecies
{
    public class FakeGroups : IMarathonGroups
    {
        private List<MarathonGroup> marathonGroups { get; set; }

        public FakeGroups()
        {
            marathonGroups = new List<MarathonGroup>()
            {
                new MarathonGroup(1,1,false,1),
                new MarathonGroup(2,0,true,1),
                new MarathonGroup(3,1,false,2),
                new MarathonGroup(4,2,false,2)
            };
        }
        public int CheckGroupFreeSpace(int group_id)
        {
            return marathonGroups.Where(x => x.group_id == group_id)
                                 .FirstOrDefault()
                                 .group_freeSpace;
        }

        public int GetDistanceFromGroup(int groupId)
        {
            return marathonGroups.Where(x => x.group_id == groupId)
                                  .FirstOrDefault()
                                  .distance_id;
        }

        public MarathonGroup GetMarathonGroup(int groupId)
        {
            return marathonGroups.Where(x => x.group_id == groupId).First();
        }
        public List<MarathonGroup> marathonGroupsIsGenerated(int marathon_id)
        {
            if(marathon_id == 1)
                return marathonGroups;
            return new List<MarathonGroup>();
        }
    }
}
