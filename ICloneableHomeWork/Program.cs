using Force.DeepCloner;

namespace ICloneableHomeWork;

class Program
{
    static void Main(string[] args)
    {
        var Lain1 = new Lain("Lain 1st", 12);
        var Lain2 = new Lain("Lain 1nd", 13);
        var Lain3 = Lain1.Clone() as Lain;
        Lain1.Name = "I am Lain";
        Lain3.Name = "I am Lain too";
        Lain3.Address.AddressInfo = "Osaka";
        Console.WriteLine("------Shallow copy------");
        Console.WriteLine(Lain1.ToString() + "\n" + Lain3.ToString());

        var DeepCloneLain = Lain1.DeepClone1();
        DeepCloneLain.Name = "I am deep clone Lain";
        DeepCloneLain.Age = 99;
        DeepCloneLain.Address.AddressInfo = "Cyber";
        Console.WriteLine("------Deep Clone------");
        Console.WriteLine(Lain1.ToString() + "\n" + DeepCloneLain.ToString());

        var cloneDeep = Lain1.DeepClone();
        cloneDeep.Address.AddressInfo = "Haven";
        Console.WriteLine("------Deep Clone by 3rd library------");
        Console.WriteLine(Lain1.ToString() + "\n" + cloneDeep.ToString());

    }
}
