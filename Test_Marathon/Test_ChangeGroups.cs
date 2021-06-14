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
        private IChangeGroupHistory changeGroupHistory;

        public MSTest_ChangeGroups()
        {
            configurationmarathon = new FakeConfiguration();
            marathonGroups = new FakeGroups();
            changeGroupHistory = new Fake_ChangeHistory();
            startingGroups = new StartingGroups(
                                                configurationmarathon,
                                                marathonGroups,
                                                changeGroupHistory);
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
        [TestMethod]
        public void ShouldChangeGroup_ParticipantDidNotChangeGroupBefore_ReturnTrue()
        {
            //given
            int participantId = 3;
            
            //when
           bool result = startingGroups.Change_CheckHistoryChangeGroupFoParticipant(participantId);
            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotChangeGroup_ParticipantDidNotChangeGroupBefore_ReturnFalse()
        {
            //given
            int participantId = 1;

            //when
            bool result = startingGroups.Change_CheckHistoryChangeGroupFoParticipant(participantId);
            //then
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldNotChangeGroup_TargetGroupHaveTheSameDistance()
        {
            //given
            int sourceGroupId = 1;
            int targetGroupId = 2;
            //when
            bool result = startingGroups.Change_CheckDistanceOfTargetGroup(sourceGroupId,targetGroupId);
            //then
        }

    }
}


