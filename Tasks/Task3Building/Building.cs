using Task1Candidates;
using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class Building
    {
        public List<Room> Rooms { get; set; }
        public Address Address { get; set; }

        public Building(List<Room> rooms, Address address)
        {
            Rooms = rooms;
            Address = address;
        }

        public override bool Equals(object obj)
        {
            return (obj is Building building && building.Address.Equals(Address));
        }

        public void AddRoom(Room roomToAdd)
        {
            if (Rooms.Contains(roomToAdd)) return;
            Rooms.Add(roomToAdd);
        }
    }
}
// Создать классы Building
// и Room ( в здании массив помещений),
// каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)