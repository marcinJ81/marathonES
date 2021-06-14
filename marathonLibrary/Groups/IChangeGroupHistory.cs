using System.Collections.Generic;

namespace marathonLibrary.Groups
{
    public interface IChangeGroupHistory
    {
        List<ChangeHistory> ListChangeHistory { get; set; }

        List<ChangeHistory> GetListOfChangeGroup(int participant_id);
    }
}