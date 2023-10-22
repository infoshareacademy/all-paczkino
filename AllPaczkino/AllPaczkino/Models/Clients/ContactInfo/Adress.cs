

namespace AllPaczkino.Clients.ContactInfo;
internal class Adress
{
    private Adress()
    {
    }

    public Adress(string streetName, int houseNumber, string cityName,string voivodeship, string postalCode,string country = "Poland", int? flatNumber = null)
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
        CityName = cityName;
        PostalCode = postalCode;
        Country = country;
        FlatNumber = flatNumber;
        voivodeship = voivodeship;
    }


    public string StreetName { get; set; }
    public int HouseNumber { get; set; }
    public string CityName { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public int? FlatNumber { get; set; }
}

