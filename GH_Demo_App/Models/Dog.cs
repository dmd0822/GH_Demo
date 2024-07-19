public class Dog(string name, int age) : Pet(name, age)
{

    //Create a property for the breed of the dog
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) 
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
