namespace Example4.Types;

public class Dog : IPet, IMammal
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }
}