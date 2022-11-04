namespace RPG
{
  class Tutorial
  {

    private static void Pause()
    {
      Console.Write("Press any key to continue...");
      Console.ReadKey();
      Console.Clear();
    }

    public static void Welcome()
    {
      Console.WriteLine("Welcome to the tutorial!");
      Console.WriteLine("In this game you will be able to fight monsters, buy items, sell items, and more!");
      Console.WriteLine("You will be able to choose your class, and your class will determine your stats!");
      Console.WriteLine("You will be able to choose your name, and your name will be displayed in the game!");
      Pause();
    }

    public static void Menu()
    {
      Console.WriteLine("This is the main menu!");
      Console.WriteLine("Here you will be able to choose your options!");
      Console.WriteLine("You can choose to see your status, enter the dungeon, see your inventory, see the shop, see the help menu, or exit the game!");
      Pause();
    }

    public static void Status()
    {
      Console.WriteLine("This is your status!");
      Console.WriteLine("Here you will be able to see your name, class, level, experience, and stats!");
      Pause();
    }

    public static void Dungeon()
    {
      Console.WriteLine("This is the dungeon!");
      Console.WriteLine("Here you will be able to fight monsters!");
      Console.WriteLine("You will be able to choose your action, and you will be able to see the monster's action!");
      Pause();
    }

    public static void Inventory()
    {
      Console.WriteLine("This is your inventory!");
      Console.WriteLine("Here you will be able to see your items!");
      Console.WriteLine("You will be able to choose your action, and you will be able to see the monster's action!");
      Pause();
    }

    public static void Shop()
    {
      Console.WriteLine("This is the shop!");
      Console.WriteLine("Here you will be able to buy and sell items!");
      Pause();
    }

  }
}