class UserInput
{
    public int getNum()
    {
        bool isInt = false;
        int val = 1;
        string? inp = "";

        while (isInt == false)
        {
            // User input
            Console.WriteLine("Enter a number to select a philosopher!");
            inp = Console.ReadLine();

            // Ensure integer is entered
            isInt = Int32.TryParse(inp, out val);
            if (isInt == false)
            {
                Console.WriteLine("Please enter a whole number!");
            }
        }
        return Convert.ToInt32(inp);
    }
}
