using marathonLibrary.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Marathon.FakeDependecies
{
    public class Fake_ChangeHistory : IChangeGroupHistory
    {
        public Fake_ChangeHistory()
        {
            ListChangeHistory = new List<ChangeHistory>()
                {
                    new ChangeHistory
                    {
                        participant_id = 1
                    },
                     new ChangeHistory
                    {
                        participant_id = 2
                    }
            };
        }
        public List<ChangeHistory> ListChangeHistory { get; set; }

        public List<ChangeHistory> GetListOfChangeGroup(int participant_id)
        {
            if (!ListChangeHistory.Any())
                return null;
            return ListChangeHistory.Where(x => x.participant_id == participant_id).ToList();
        }
    }
}
