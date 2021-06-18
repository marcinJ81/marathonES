namespace marathonLibrary
{
    public interface IStartingGroup
    {
        IDomainResult Change(int marathonId, int targetGroupId, int participantId);
    }
}