public class Cat(string name, int age, string furColor) : Pet(name, age)
{
    //create a property for Fur Color 
    public string FurColor { get; set; }

    //create a property for IsDeclawed
    public bool IsDeclawed { get; set; }


    public void Speak()
    {
        Console.WriteLine("Meow!");
    }

    public void Purr()
    {
        Console.WriteLine($"{Name} is purring.");
    }
}
