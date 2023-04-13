namespace Open_Closed;

public class MagicClass
{
    public void CountYourMagic(Magic? Power)
    {
        if (Power != null)
        {
            Console.WriteLine($"Wow, you are a {Power.MagicName}");
            return;
        } 
        Console.WriteLine("And I don`t know who are you! ahahah");
    }
}