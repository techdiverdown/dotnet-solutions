namespace Example4.Types;

public class Parrot : IPet
{
    public string Name { get; set; }
    public bool CanTalk { get; set; }
   
    public Parrot (string name, bool canTalk)
    {
        Name = name;
        CanTalk = canTalk;
    }
}