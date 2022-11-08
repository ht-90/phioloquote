class Philosopher
{
    public int Id;
    public string Name;
    public string Born;
    public string Lived;
    public string[] Quotes;

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
