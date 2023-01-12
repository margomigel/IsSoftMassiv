using Task1Candidates;
using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class Building
    {
        public List<Room> rooms;
        public Address Address { get; set; }

        public Building(List<Room> rooms, Address address)
        {
            this.rooms = rooms;
            Address = address;
        }

        public override bool Equals(object obj)
        {
            if (obj is Building)
            {
                Building building = obj as Building;
                return building.Address.Equals(Address);
            }

            {
                return false;
            }
        }

        public void AddRoom(Room roomToAdd)
        {
            foreach (Room room in rooms)
            {
                if (room.Equals(roomToAdd))
                {
                    return;
                }
            }
            rooms.Add(roomToAdd);
        }
    }
}
// Создать классы Building
// и Room ( в здании массив помещений),
// каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)