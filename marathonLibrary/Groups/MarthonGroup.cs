using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathonLibrary.Groups
{
    public class MarathonGroup 
    {
        public int group_id { get; private set; }
        public int group_freeSpace { get; private set; }
        public bool group_Closed { get; private set; }
        public int distance_id { get; private set; }

        public MarathonGroup(int id, int freeSpace, bool close, int distance)
        {
            this.group_id = id;
            this.group_Closed = close;
            this.group_freeSpace = freeSpace;
            this.distance_id = distance;
        }
    }
}
