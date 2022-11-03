namespace RPG
{
  class GameControl
  {

    public static void Start()
    {
      Console.Clear();
      Console.WriteLine("Welcome to the RPG Game!");
      Console.Write("Choose an option: ");
      string option = Console.ReadLine()!;
      switch (option)
      {
        case "start":
          Console.Clear();
          Console.Write("Take your name: ");
          string name = Console.ReadLine()!;
          Console.WriteLine("Class options: warrior, mage, archer");
          Console.Write("Choose your class: ");
          string classPlayer = Console.ReadLine()!;
          Player player = new Player(name, classPlayer);
          Game game = new Game(player);
          break;
        case "exit":
          Console.Clear();
          Console.WriteLine("Thanks for playing!");
          Console.ReadKey();
          break;
        case "help":
          Console.Clear();
          Console.WriteLine("start - Start the game");
          Console.WriteLine("exit - Exit the game");
          Console.Write("Press any key to continue...");
          Console.ReadKey();
          Start();
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid option!");
          Start();
          break;
      }
    }

    public static void Dungeon(Player player)
    {
      Console.Clear();
      Console.WriteLine("You are in the dungeon!");
      Random random = new Random();
      DungeonControl dungeon = new DungeonControl();

      bool isDungeon = true;
      int sizeForDungeon = random.Next(5, 20);
      int currentSize = 0;

      while (isDungeon)
      {
        if (currentSize == sizeForDungeon)
        {
          isDungeon = !isDungeon;
          Console.WriteLine("You've finished the dungeon!");
          Console.Write("Press any key to continue...");
          Console.ReadKey();
        }
        else
        {
          dungeon.Dungeon(player);
          Console.Clear();
          Console.WriteLine($"Progress: {(currentSize * 100) / sizeForDungeon}%");
          Console.Write("Continue? [y/n]: ");
          string option = Console.ReadLine()!;
          switch (option)
          {
            case "yes":
              currentSize++;
              Console.Clear();
              break;
            case "no":
              Console.Clear();
              isDungeon = false;
              break;
            default:
              Console.Clear();
              Console.WriteLine("Invalid option!");
              break;
          }
        }

      }
    }


  }
}