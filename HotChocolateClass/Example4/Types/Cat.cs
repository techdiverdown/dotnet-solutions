namespace Example4.Types;

public class Cat : IPet, IMammal
{
    public string Name { get; set; }
    public bool IsEvil { get; set; }
    
    public CatLives Lives { get; set; }

    public Cat(string name, bool isEvil, CatLives lives)
    {
        Name = name;
        IsEvil = isEvil;
        Lives = lives;
    }
    
    public enum CatLives
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }
}