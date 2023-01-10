using System;

namespace Tasks.Task3Building
{
    internal class Room
    {
        public string RoomNumber { get; set; } 
        public string Appointment { get; set; }

        public  Room (string roomNumber, string appointment) 
        {
            RoomNumber = roomNumber;
            Appointment = appointment;
        }
    }
}
//// и Room ( в здании массив помещений),
// каждое помещение имеет назначение- лекционное, лабораторное, семинарское, вспомогательное)