
using Task1Candidates;

namespace Tasks.Task3Building
{
    public class Building
    {
        public Room[] rooms; 
        public Address Address { get; set; }
        

        public Building(Room[] rooms, Address address) 
        {
            this.rooms = rooms;
            Address = address;
        }
    }
}
// Создать классы Building
// и Room ( в здании массив помещений),
// каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)