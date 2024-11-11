internal class Program
{
    private static void Main(string[] args)
    {
        Address address = new Address();
        address.Index = "123"; 
        Console.WriteLine(address.Index);
        address.Country = "Ukraine";
        Console.WriteLine(address.Country);
        address.City = "Kyiv";
        Console.WriteLine(address.City);
        address.Street = "Street";
        Console.WriteLine(address.Street);
        address.House = "33";
        Console.WriteLine(address.House);
        address.Apartment = "A";
        Console.WriteLine(address.Apartment);


    }
}
class Address
{
    string index;
    public string Index { get { return index; } set { index = value; } }
    
    string country;
    public string Country { get { return country; } set { country = value; } }
   
    string city;
    public string City { get { return city; } set { city = value; } }
    
    string street;
    public string Street { get { return street; } set { street = value; } } 
    
    string house;
    public string House { get { return house; } set { house = value; } }

    string apartment;
    public string Apartment { get { return apartment; } set { apartment = value; } }
}