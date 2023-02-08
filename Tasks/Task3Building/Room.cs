using Task2UniverEmployee;

namespace Tasks.Task3Building
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Appointment { get; set; }

        public Room(int roomNumber, string appointment)
        {
            RoomNumber = roomNumber;
            Appointment = appointment;
        }

        public override bool Equals(object obj)
        {
            if (obj is Room room)
            {
                return room.RoomNumber.Equals(RoomNumber)
                       && room.Appointment.Equals(Appointment);
            }
            return false;
        }
    }
}
//// и Room ( в здании массив помещений),
// каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)