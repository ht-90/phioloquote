﻿class Program
{
    static void Main(string[] args)
    {
        // Generate dataset
        Philosopher FNietzsche = new Philosopher(
            1, "Friedrich Nietzsche", "Germany", "1844-1900",
            new string[] {
                "That which does not kill us makes us stronger.",
                "Sometimes people don’t want to hear the truth because they don’t want their illusions destroyed.",
                "It's not a lack of love, but a lack of friendship that makes unhappy marriages.",
                "What does your conscience say? — ‘You should become the person you are’.",
                "God is dead! He remains dead! And we have killed him."
            }
        );
        Philosopher CJung = new Philosopher(
            2, "Carl Jung", "Switzerland", "1875-1961",
            new string[] {
                "Until you make the unconscious conscious, it will direct your life and you will call it fate.",
                "We are not what happened to us, we are what we wish to become.",
                "Who looks outside, dreams; who looks inside, awakes.",
                "Thinking is difficult, that’s why most people judge."
            }
        );
        Philosopher RDescartes = new Philosopher(
            3, "Rene Descartes", "France", "1596-1650",
            new string[] {
                "I think; therefore I am.",
                "The reading of all good books is like conversation with the finest men of past centuries.",
                "Conquer yourself rather than the world.",
                "Doubt is the origin of wisdom.",
                "To know what people really think, pay attention to what they do, rather than what they say."
            }
        );
        Philosopher IKant = new Philosopher(
            4, "Immanuel Kant", "Germany", "1724-1804",
            new string[] {
                "We are not rich by what we possess but by what we can do without.",
                "Happiness is not an ideal of reason but of imagination."
            }
        );

        Philosopher Plato = new Philosopher(
            5, "Plato", "Greece", "428BCE-347BCE",
            new string[] {
                "We can easily forgive a child who is afraid of the dark; the real tragedy of life is when men are afraid of the light.",
                "Thinking – the talking of the soul with itself.",
                "Opinion is the medium between knowledge and ignorance."
            }
        );

        // Display available philosophers
        Console.WriteLine($"{FNietzsche.Id}: {FNietzsche.Name} - {FNietzsche.Quotes.Length} Quotes");
        Console.WriteLine($"{CJung.Id}: {CJung.Name} - {CJung.Quotes.Length} Quotes");
        Console.WriteLine($"{RDescartes.Id}: {RDescartes.Name} - {RDescartes.Quotes.Length} Quotes");
        Console.WriteLine($"{IKant.Id}: {IKant.Name} - {IKant.Quotes.Length} Quotes");
        Console.WriteLine($"{Plato.Id}: {Plato.Name} - {Plato.Quotes.Length} Quotes" + "\n");

        // Get user selection
        UserInput userInp = new UserInput();
        int selectNum = userInp.getNum();

        // Display quotes
        switch (selectNum)
        {
            case 1:
                FNietzsche.stateQuote();
                break;
            case 2:
                CJung.stateQuote();
                break;
            case 3:
                RDescartes.stateQuote();
                break;
            case 4:
                IKant.stateQuote();
                break;
            case 5:
                Plato.stateQuote();
                break;
            default:
                Console.WriteLine("Not a valid selection ;_;" + "\n");
                break;
        }
    }
}