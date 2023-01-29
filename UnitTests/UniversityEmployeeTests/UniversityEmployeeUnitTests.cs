using Task1Candidates;
using Task2UniverEmployee;
using Tasks.Task3Building;

namespace UnitTests
{
    [TestClass]
    public class UniversityEmployeeUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckUniversityEmployeeTaxId()
        {
            UniversityEmployee universityEmployee = new SupportStaff(
                new Person("Name", "Surname", new Address("City", "Street", 1, 2)),
                -1234,
                "duties"
                );
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckLenghtEmployeeNegative()
        {
            UniversityEmployee universityEmployee = new SupportStaff(
                new Person("NameNameName", "SurnameSurname", new Address("City", "Street", 1, 2)),
                1234,
                "duties"
                );
        }

                [TestMethod]
                public void CheckGetOfficialDutiesPositive()
                {
                    UniversityEmployee universityEmployee = new SupportStaff(
                        new Person("Name", "Surname", new Address("City", "Street", 1, 2)),
                        1234,
                        "cleaner"
                        );

                    Assert.AreEqual("cleaner duties", universityEmployee.GetOfficialDuties());
                }

        [TestMethod]
        public void CheckUniversityEmployeesEqualsPositive()
        {
            UniversityEmployee universityEmployee1 = new SupportStaff(
                new Person("Name1", "Surname1", new Address("City1", "Street1", 1, 2)),
                1234,
                "cleaner"
                );

            UniversityEmployee universityEmployee2 = new SupportStaff(
                    new Person("Name2", "Surname2", new Address("City2", "Street2", 1, 2)),
                    1234,
                    "cleaner"
                    );

            ReferenceEquals(universityEmployee1, universityEmployee2);
        }

        [TestMethod]
        public void CheckUniversityEmployeesEqualsNegative()
        {
            UniversityEmployee universityEmployee1 = new SupportStaff(
                new Person("Name1", "Surname1", new Address("City1", "Street1", 1, 2)),
                1234,
                "cleaner"
                );

            UniversityEmployee universityEmployee2 = new SupportStaff(
                    new Person("Name2", "Surname2", new Address("City2", "Street2", 1, 2)),
                    2345,
                    "cleaner"
                    );

            Assert.AreNotEqual(universityEmployee1, universityEmployee2);
        }
    }
}