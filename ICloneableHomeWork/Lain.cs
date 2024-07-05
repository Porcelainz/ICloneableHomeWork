class Lain : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address{ get; set; }
    public Lain(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
        this.Address = new Address("Tokyo");
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public Lain DeepClone1()
    {
        Lain clone = new Lain(this.Name, this.Age);
        return clone;

    }

    public override string ToString()
    {
        return $"{Name}, {Age} years old. liveing in {Address.AddressInfo}";
    }
}

class Address
{
    public string AddressInfo { get; set; }
    public Address(string AddressInfo)
    {
        this.AddressInfo = AddressInfo;
    }
}