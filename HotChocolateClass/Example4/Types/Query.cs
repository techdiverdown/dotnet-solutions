namespace Example4.Types;

public class Query
{
    private bool _dog;

    // this is the resolver method
    public Book Books() => new Book("The Hobbit", new Author("J.R.R. Tolkien"));

    // another resolver method
    public IEnumerable<IPet> GetPets() => new List<IPet>
    {
        new Dog("Fido", "Golden Retriever"),
        new Cat("Whiskers", true, Cat.CatLives.Five),
        new Parrot("Polly", true),
        new Cat(name:"Fluffy", isEvil:false, lives:Cat.CatLives.Two),
        new Cat(name:"Mittens", isEvil:true, lives:Cat.CatLives.Seven)
    };

    // another resolver method
    public IMammal GetCatOrDog()
    {
        _dog = !_dog;
        return _dog
            ? new Dog("Fido", "Golden Retriever")
            : new Cat("Whiskers", true, Cat.CatLives.Nine);
    }

    // resolver for enum types
    public IEnumerable<Cat> getAllCats(Cat.CatLives? lives)
    {
        if (lives is not null) {
            return GetPets().OfType<Cat>().Where(t => t.Lives == lives);
        }

        return GetPets().OfType<Cat>();

    }

    // resolver for OneOf types
    public string GetDogOrCatName(DogOrCat catOrDog)
    {
        return catOrDog.Cat?.Name ?? catOrDog.Dog?.Name!;
    }
    
    // OneOf types are used to return one of several types
    // this is useful when you want to return a type that could be one of several types
    [OneOf]
    public record DogOrCat(Dog? Dog, Cat? Cat);
    }