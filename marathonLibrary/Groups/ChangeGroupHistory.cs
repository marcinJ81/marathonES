using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathonLibrary.Groups
{
    public class ChangeHistory
    {
        public int participant_id { get; set; }
    }
    public class ChangeGroupHistory : IChangeGroupHistory
    {
        public List<ChangeHistory> ListChangeHistory { get; set; }

        public List<ChangeHistory> GetListOfChangeGroup(int participant_id)
        {
            if (!ListChangeHistory.Any())
                return null;
            return ListChangeHistory.Where(x => x.participant_id == participant_id).ToList();
        }
    }
}
