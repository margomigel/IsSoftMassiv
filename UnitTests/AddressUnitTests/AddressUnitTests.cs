using Task1Candidates;
namespace UnitTests
{
    [TestClass]
    public class AddressUnitTests
    {
        [TestMethod]
        public void CheckEqualsAddressPositive()
        {
            Address address1 = new("city", "street", 11, 22);
            Address address2 = new("city", "street", 11, 22);

            Assert.IsTrue(address1.Equals(address2));
        }

        [TestMethod]
        public void CheckEqualsAddressNegative()
        {
            Address address1 = new("city", "street", 11, 22);
            Address address2 = new("city2", "street", 11, 22);

            Assert.IsFalse(address1.Equals(address2));
        }

        [TestMethod]
        public void CheckEqualsAddressNegativeStreet()
        {
            Address address1 = new("city", "street", 11, 22);
            Address address2 = new("city", "street2", 11, 22);

            Assert.IsFalse(address1.Equals(address2));
        }

        [TestMethod]
        public void CheckEqualsAddressNegativeHouse()
        {
            Address address1 = new("city", "street", 11, 22);
            Address address2 = new("city", "street", 101, 22);

            Assert.IsFalse(address1.Equals(address2));
        }

        [TestMethod]
        public void CheckEqualsAddressNegativeAppartment()
        {
            Address address1 = new("city", "street", 11, 22);
            Address address2 = new("city", "street", 11, 32);

            Assert.IsFalse(address1.Equals(address2));
        }

        [TestMethod]
        public void CheckAddressToString()
        {
            Address address1 = new("city", "street", 11, 11);
            string result = address1.ToString();

            Assert.AreEqual("city, street, 11, 11", result);
        }
    }
}