using Task1Candidates;
using Tasks.Task3Building;

namespace UnitTests
{
    [TestClass]
    public class BuildingUnitTests
    {
        [TestMethod]
        public void CheckBuildingsEqualsPositive()
        {
            Building building1 = new(new List<Room> { }, new("city", "street", 11, 12));
            Building building2 = new(new List<Room> { }, new("city", "street", 11, 12));

            Assert.IsTrue(building1.Equals(building2));
        }

        [TestMethod]
        public void CheckBuildingsEqualsNegative()
        {
            Building building1 = new(new List<Room> { }, new("city", "street", 11, 12));
            Building building2 = new(new List<Room> { }, new("city1", "street1", 11, 12));

            Assert.IsFalse(building1.Equals(building2));
        }

        [TestMethod]
        public void CheckAddRoomPositive()
        {
            Building building1 = new(new List<Room> { new(11, "sm"), new(12, "sm"), new(13, "sm") }, new("city", "street", 11, 12));
            Room room = new Room(14, "sme");
                building1.AddRoom(room);

            Assert.AreEqual(4, building1.Rooms.Count());
            Assert.IsTrue(building1.Rooms.Contains(room));
            
        }
    }
}
