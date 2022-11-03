namespace RPG
{
  class Game
  {
    // propriedade
    private bool _gameOver = false;
    private Player? player;

    public Game(Player player)
    {
      this.player = player;
      Start();
    }

    private void Start()
    {
      while (!_gameOver)
      {
        Update();
      }

      End();
    }

    private void Update()
    {
      Console.Clear();
      MainMenu();
    }

    private void End()
    {
      Console.WriteLine("Goodbye!");
    }

    private void MainMenu()
    {
      Console.WriteLine("Zé's Tavern");
      Console.Write("Choose an option: ");
      string option = Console.ReadLine()!;
      switch (option)
      {
        case "status":
          Console.Clear();
          player!.Status();
          break;
        case "dungeon":
          Console.Clear();
          GameControl.Dungeon(player!);
          break;
        case "inventory":
          Console.Clear();
          InventoryControl.ShowInventory(player!);
          InventoryMenu.ChooseOptionInventory(player!);
          break;
        case "help":
          Console.Clear();
          Help();
          break;
        case "exit":
          Console.Clear();
          _gameOver = true;
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid option!");
          MainMenu();
          break;
      }
    }

    private void Help()
    {
      Console.WriteLine("status - Show your status");
      Console.WriteLine("dungeon - Enter the dungeon");
      Console.WriteLine("inventory - Show your inventory");
      Console.WriteLine("help - Show the help menu");
      Console.WriteLine("exit - Exit the game");
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }
  }
}