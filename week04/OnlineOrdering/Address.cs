using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = province;
        _country = country;
    }

    public bool InUsa()
    {
        return _country == "United States";
    }

    public string FullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince},\n{_country}";
    }
}