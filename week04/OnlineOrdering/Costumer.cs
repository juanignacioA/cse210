public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUSA()
    {
        return _address.LiveInUSA();
    }

    public string GetName() => _name;

    public string GetAddressDetails()
    {
        return _address.GetFullAddress();
    }
}