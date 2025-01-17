public class Cat : Pet
{
    //create a property for Fur Color 
    public string FurColor { get; set; }

    //Create a property for IsDeclawed
    public bool IsDeclawed { get; set; }

    //create a property for IsLitterTrained
    public bool IsLitterTrained { get; set; }

    public Cat(string name, int age, string furColor) : base(name, age)
    {
        FurColor = furColor;

    }

    public void Speak()
    {
        Console.WriteLine("Meow!");
    }

    public void Purr()
    {
        Console.WriteLine($"{Name} is purring.");
    }
}
