namespace WebApplication1.Models
{
    public class SeedData
    {
        //public List<Person> PopulateAllPerson()
        //{
        //    return new List<Person>
        //        {
        //            new Person("Karthik", "karthik@techgeek.co.in", 1234322,
        //                new Address("Thistledew place", "Auckland", "NZ")),

        //            new Person("Prashanth", "Prashanth@gmail.com", 23452342,
        //                new Address("Thistledew place", "Auckland", "NZ")),

        //            new Person("John", "john@gmail.com", 345334,
        //                new Address("Virumbakkam", "TamilNadu", "IN")),

        //            new Person("Ramesh", "ramesh@gmail.com", 5645645,
        //                new Address("White street", "London", "UK"))
        //        };
        //}


        public List<Person> PopulateAllPerson()
        {
            return new List<Person>
            {
                new ()
                {
                    Name = "Karthik",
                    Email = "karthik@techgeek.co.in",
                    Phone = "1234322",
                    Address = new Address
                    {
                        StreetName = "Thistledew place",
                        State = "Auckland",
                        Country = "NZ"
                    }
                },

                new ()
                {
                    Name = "Prashanth",
                    Email = "Prashanth@gmail.com",
                    Phone = "23452342",
                    Address = new Address
                    {
                        StreetName = "Thistledew place",
                        State = "Auckland",
                        Country = "NZ"
                    }
                },

                new ()
                {
                    Name = "John",
                    Email = "John@gmail.com",
                    Phone = "345334",
                    Address = new Address
                    {
                        StreetName = "Virubakkam",
                        State = "Tamil Nadu",
                        Country = "IN"
                    }
                },

                new ()
                {
                    Name = "Ramesh",
                    Email = "ramesh@gmail.com",
                    Phone = "5645645",
                    Address = new Address
                    {
                        StreetName = "White Street",
                        State = "London",
                        Country = "UK"
                    }
                }
            };
        }
    }
}
