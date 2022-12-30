using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSoftMassiv
{
    public class Address
    {
        public string City;
        public string Street;
        public int House;
        public int Appartment;

        public Address (string city, string street, int house, int appartment)
        {
            City = city;
            Street = street;
            House = house;
            Appartment = appartment;
        }
    }
}
