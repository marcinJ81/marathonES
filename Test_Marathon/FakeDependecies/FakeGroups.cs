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
        public int CheckGroupFreeSpace(int group_id)
        {
            if (group_id == 1)
                return 1;
            else
                return 0;
        }

        public int GetDistanceFromGroup(int groupId)
        {
            if(groupId == 1)
                return 1;
            else
                return 2;
        }
    }
}
