public class Dog(string name, int age) : Pet(name, age)
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }

    public void WagTail()
    {
        Console.WriteLine($"{Name} is wagging its tail.");
    }
}
