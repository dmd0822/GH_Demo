public class Dog : Pet
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public void Speak()
    {
        Console.WriteLine("Woof!");
    }

    public void WagTail()
    {
        Console.WriteLine($"{Name} is wagging its tail.");
    }
}
