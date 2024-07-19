public class Dog : Pet
{
    //Create a property for the breed of the dog
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
