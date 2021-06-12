using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathonLibrary.Groups
{
    public class MarathonGroups : IMarathonGroups
    {
        public int group_id { get; private set; }
        private int group_freeSpace;
        public bool group_Closed { get; private set; }

        public MarathonGroups(int id, int freeSpace, bool close)
        {
            this.group_id = id;
            this.group_Closed = close;
            this.group_freeSpace = freeSpace;
        }
        public int CheckGroupFreeSpace(int id)
        {
            return this.group_freeSpace;
        }
    }
}
