namespace WebApplication1.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Address Address { get; set; }

    }


    public class Address
    {
        public string StreetName { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }
}
