public class Dog : Pet
{
    //create a property for Breed
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;

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
