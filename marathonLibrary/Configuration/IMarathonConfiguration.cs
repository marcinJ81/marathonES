using System;

namespace marathonLibrary.Configuration
{
    public interface IMarathonConfiguration
    {
        DateTime GetGroupChangeDeadline(int marathonId);
    }
}