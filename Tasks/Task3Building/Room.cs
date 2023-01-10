using System;

namespace Tasks.Task3Building
{
    public class Room
    {
        public int RoomNumber { get; set; } 
        public string Appointment { get; set; }

        public  Room (int roomNumber, string appointment) 
        {
            RoomNumber = roomNumber;
            Appointment = appointment;
        }
    }
}
//// и Room ( в здании массив помещений),
// каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)