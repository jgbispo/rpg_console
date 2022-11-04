namespace RPG
{
  class PlayerControl
  {
    private static bool isTutorialStatus = false;

    public static void Status(bool isTutorial, Player player)
    {
      Console.Clear();
      if (isTutorial && !isTutorialStatus) { Tutorial.Status(); isTutorialStatus = true; }
      Console.WriteLine("Status");
      Console.WriteLine("Name: " + player.Name);
      Console.WriteLine("Class: " + player.ClassPlayer);
      Console.WriteLine("Level: " + player.Level);
      Console.WriteLine("Experience: " + player.Experience);
      Console.WriteLine("Gold: " + player.Gold);  
      Console.WriteLine("Health: " + player.Health + "/" + player.MaxHealth);
      Console.WriteLine("Mana: " + player.Mana + "/" + player.MaxMana);
      Console.WriteLine("Strength: " + player.Strength);
      Console.WriteLine("Magic: " + player.Magic);
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    public static void StatusCombat(Player player)
    {
      Console.Clear();
      Console.WriteLine("Name: " + player.Name);
      Console.WriteLine("Health: " + player.Health);
    }

    public static void ShowInventory()
    {
      Console.Clear();
      Console.WriteLine("Inventory");
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    public static void Damage(int strength, Player player)
    {
      player.Health -= strength;
    }
    public static void LevelUp(Player player)
    {
      player.Level += 1;
      player.MaxHealth += 10;
      player.MaxMana += 10;
      player.Strength += 5;
      player.Magic += 5;
      player.MaxItem += 5;
      Console.Clear();
      Console.WriteLine("You leveled up!");
      Console.WriteLine("You are now level " + player.Level);
      Console.WriteLine("Up Health: " + player.Health);
      Console.WriteLine("Up Mana: " + player.Mana);
      Console.WriteLine("Up Strength: " + player.Strength);
      Console.WriteLine("Up Magic: " + player.Magic);
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }
  }
}