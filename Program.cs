internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Message mes;
        Console.WriteLine("1 - New game");
        Console.WriteLine("2 - Load game");
        Console.WriteLine("3 - Rules");
        Console.WriteLine("4 - Authors");
        Console.WriteLine("0 - Exit");

        int ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 1)
        {
            mes = NewGame;
        }
        else if (ans == 2)
        {
            mes = LoadGame;
        }
        else if (ans == 3)
        {
            mes = Rules;
        }
        else if (ans == 4)
        {
            mes = Authors;
        }
        else if (ans == 0)
        {
            mes = Exit;
        }
        else mes = Exit;
        mes();
    }
    static void NewGame()
    {
        Console.Clear();
        Console.WriteLine("Starting new game...");
    }
    static void LoadGame()
    {
        Console.Clear();
        Console.WriteLine("Loading a save...");
    }
    static void Rules()
    {
        Console.Clear();
        Console.WriteLine("Don't be toxic and show respect to other players!");
    }
    static void Authors()
    {
        Console.Clear();
        Console.WriteLine("The one and the only: Alex Untilov");
    }
    static void Exit()
    {
        Console.Clear();
        Console.WriteLine("Bye...");
    }
    delegate void Message();
}
