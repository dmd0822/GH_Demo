public class Dog(string name, int age, string breed) : Pet(name, age)
{

    //Create a property for the breed of the dog
    public string Breed { get; set; }

    //create a property for the dog's weight
    public int Weight { get; set; }

   
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }

    public void WagTail()
    {
        Console.WriteLine($"{Name} is wagging its tail.");
    }
}
