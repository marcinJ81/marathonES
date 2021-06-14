using marathonLibrary;
using marathonLibrary.Configuration;
using marathonLibrary.Groups;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Marathon.FakeDependecies;

namespace marathonLibrary.Tests
{
    //Nunit not work because he do not support .net core 5
    [TestClass]
    public class MSTest_ChangeGroups
    {
        private IStartingGroups startingGroups;
        private IMarathonConfiguration configurationmarathon;
        private IMarathonGroups marathonGroups;

        public MSTest_ChangeGroups()
        {
            configurationmarathon = new FakeConfiguration();
            marathonGroups = new FakeGroups();
            startingGroups = new StartingGroups(configurationmarathon, marathonGroups);
        }

        [TestMethod]
        public void ShouldChangeGroup_DeadlineNotExceeded_ReturnTrue()
        {
            //given
            int marathonId = 1;
            //when
            bool result = startingGroups.Change_CheckDeadline(marathonId);
            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotChangeGroup_DeadlineExceeded_ReturnFalse()
        {
            //given
            int marathonId = 2;
            //when
            bool result = startingGroups.Change_CheckDeadline(marathonId);
            //then
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ShouldChangeGroup_GroupHaveFreeSpace_ReturnTrue()
        {
            //given
            int groupId = 1;
            //when
            bool result = startingGroups.Change_CheckFreeSpaceInStartingGroup(groupId);
            //then
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ShouldNotChangeGroup_GroupHaveNotFreeSpace_ReturnFalse()
        {
            //given
            int groupId = 0;
            //when
            bool result = startingGroups.Change_CheckFreeSpaceInStartingGroup(groupId);
            //then
            Assert.IsFalse(result);
        }

        

    }
}


