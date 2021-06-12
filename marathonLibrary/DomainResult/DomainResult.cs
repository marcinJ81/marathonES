using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathonLibrary
{
    public class DomainResult : IDomainResult
    {
        public string StartingGroupHasChange(bool param)
        {
            return param ? "Group has been change" : "You can not change group";
        }
    }
}
