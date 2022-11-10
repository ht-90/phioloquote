namespace Classes;

public class Philosopher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Born { get; set; }
    public string Lived { get; set; }
    public string[] Quotes { get; set; }

    public Philosopher(int id, string name, string born, string lived, string[] quotes)
    {
        Id = id;
        Name = name;
        Born = born;
        Lived = lived;
        Quotes = quotes;
    }

    public void stateQuote()
    {
        Console.WriteLine("\n");
        foreach (string q in Quotes)
        {
            Console.WriteLine($"\"\"\"\n   {q}\n");
        }
        Console.WriteLine("\"\"\"");
        Console.WriteLine($"\n   ({Name})\n");
    }
}
