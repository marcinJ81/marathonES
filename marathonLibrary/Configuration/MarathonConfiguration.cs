using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathonLibrary.Configuration
{
    public class MarathonConfiguration : IMarathonConfiguration
    {
        private int Marathon_id;
        private string MarathonName;
        private DateTime GroupChangeDeadline;

        public MarathonConfiguration( int id, string name, DateTime dateGroup)
        {
            this.Marathon_id = id;
            this.MarathonName = name;
            this.GroupChangeDeadline = dateGroup;
        }

        public DateTime GetGroupChangeDeadline(int marathonId)
        {
            return this.GroupChangeDeadline;
        }
    }
}
