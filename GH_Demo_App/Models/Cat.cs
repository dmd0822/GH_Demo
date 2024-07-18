public class Cat : Pet
{
    public Cat(string name, int age) : base(name, age)
    {
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
