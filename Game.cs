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
      Console.WriteLine("Main Menu");
      Console.WriteLine("1 - Status");
      Console.WriteLine("2 - Go to dungeon");
      Console.WriteLine("3 - Exit");
      Console.Write("Choose an option: ");
      string option = Console.ReadLine()!;
      switch (option)
      {
        case "1":
          Console.Clear();
          player!.Status();
          break;
        case "2":
          Console.Clear();
          GameControl.Dungeon(player!);
          break;
        case "3":
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
  }
}