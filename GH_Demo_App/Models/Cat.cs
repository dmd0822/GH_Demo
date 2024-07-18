public class Cat : Pet
{
    //create a property for Fur Color 
    public string FurColor { get; set; }

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
