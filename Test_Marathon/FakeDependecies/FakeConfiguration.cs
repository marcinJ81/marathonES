using marathonLibrary.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Marathon.FakeDependecies
{
    public class FakeConfiguration : IMarathonConfiguration
    {
        public DateTime GetGroupChangeDeadline(int marathonId)
        {
            if(marathonId == 1)
            {
                DateTime dateTime = DateTime.Today.AddDays(1);
                return dateTime;
            }
            return new DateTime(2021, 6, 1);

        }
    }
}
