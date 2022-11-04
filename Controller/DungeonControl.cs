namespace RPG
{
  class DungeonControl
  {
    // Proprieties
    private Enemy[] enemies = new Enemy[5];
    private Item[]? items;
    private Player? player;

    public void Dungeon(Player player)
    {
      Console.Clear();
      this.player = player;
      items = Items.CreateItem(items!);
      PrizeDraw();
    }

    private void PrizeDraw()
    {
      Random random = new Random();
      int prize = random.Next(1, 20);

      if (prize <= 10)
      {
        Walk();
      }
      else if (prize <= 15)
      {
        Fight();
      }
      else if (prize <= 20)
      {
        Found();
      }
      else
      {
        Console.WriteLine("D20 fell, rolling D2...");
        prize = random.Next(1, 2);
        if (prize == 1)
        {
          Walk();
        }
        else
        {
          Found();
        }
      }
    }

    private void Walk()
    {
      Console.Clear();
      Console.WriteLine("You are walking...");
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    private int Dice()
    {
      Random random = new Random();
      int dice = random.Next(1, 20);
      return dice;
    }

    private void Fight()
    {
      Console.Clear();
      Console.WriteLine("You are fighting...");
      Enemy enemy = SpawnEnemies();
      enemy.ShowName();
      Console.Write("Press any key to continue...");
      Console.ReadKey();
      bool isBattle = true;
      Battle(isBattle, enemy);
    }

    private void Battle(bool isBattle, Enemy enemy)
    {
      while (isBattle)
      {
        Console.Clear();
        player!.StatusCombat();
        Console.WriteLine();
        enemy.StatusCombat();
        Console.WriteLine();
        Console.Write("Choose your action: ");
        string option = Console.ReadLine()!;

        Console.WriteLine("Rolling the dice...\n");
        int dice = Dice();
        Console.WriteLine("You rolled a " + dice + "!\n");

        switch (option)
        {
          case "sword":
            Console.Clear();
            Console.WriteLine("You chosen sword...");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            isBattle = Combat.Battle(dice, player!, option, enemy, isBattle);
            AttStatus(player);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            break;
          case "magic":
            Console.Clear();
            Console.WriteLine("You chosen magic...");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            isBattle = Combat.Battle(dice, player!, option, enemy, isBattle);
            AttStatus(player);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            break;
          case "run":
            Console.Clear();
            Console.WriteLine("You are running...");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            isBattle = Combat.Run(dice, isBattle, enemy, player!);
            AttStatus(player);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            break;
          case "potion mana":
            Console.Clear();
            Console.WriteLine("You are using an item...");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            isBattle = Combat.UsePotionMana(dice, isBattle, enemy, player!);
            AttStatus(player);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            break;
          case "potion health":
            Console.Clear();
            Console.WriteLine("You are using an item...");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            isBattle = Combat.UsePotionHealth(dice, isBattle, enemy, player!);
            AttStatus(player);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            break;
          default:
            Console.Clear();
            Console.WriteLine("Invalid option!");
            break;
        }
      }
    }

    private Enemy SpawnEnemies()
    {
      Random random = new Random();
      int enemyCount = random.Next(1, 5);
      int multiplier = (player!.Level * 100) / 20;
      for (int i = 0; i < enemyCount; i++)
      {
        int enemyType = random.Next(0, 5);
        switch (enemyType)
        {
          case 0:
            return enemies[i] = new Enemy("Goblin", 10 * multiplier, (2 * multiplier) / 2, 5 * multiplier, 10 * multiplier);
          case 1:
            return enemies[i] = new Enemy("Orc", 15 * multiplier, (3 * multiplier) / 2, 10 * multiplier, 15 * multiplier);
          case 2:
            return enemies[i] = new Enemy("Skeleton", 20 * multiplier, (4 * multiplier) / 2, 15 * multiplier, 20 * multiplier);
          case 3:
            return enemies[i] = new Enemy("Zombie", 25 * multiplier, (5 * multiplier) / 2, 20 * multiplier, 25 * multiplier);
          case 4:
            return enemies[i] = new Enemy("Dragon", 30 * multiplier, (6 * multiplier) / 2, 25 * multiplier, 30 * multiplier);
        }
      }
      return enemies[0];
    }

    private static void AttStatus(Player player)
    {
      if (player.Health <= 0)
      {
        Console.WriteLine("You are dead! GAME OVER!");
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        GameControl.Start();
      }

      if (player.Mana <= 0)
      {
        Console.WriteLine("You are out of mana!");
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        GameControl.Start();
      }

      if (player.Experience >= 100)
      {
        player.LevelUp();
      }
    }

    private void Found()
    {
      Console.Clear();
      Console.WriteLine("You found something...");
      Console.Write("Press any key to continue...");
      Console.ReadKey();
      Console.Clear();
      Item item = FoundItem();
      Console.WriteLine("You found a " + item.GetName() + "!");
      Console.Write("Press any key to continue...");
      InventoryControl.AddItem(player!, item);
      Console.ReadKey();
    }

    private Item FoundItem()
    {
      Random random = new Random();
      int currentLevel = player!.Level;
      if (currentLevel <= 5)
      {
        int item = random.Next(0, 5);
        return items![item];
      }
      else if (currentLevel <= 10)
      {
        int item = random.Next(6, 10);
        return items![item];
      }
      else if (currentLevel <= 15)
      {
        int item = random.Next(11, 15);
        return items![item];
      }
      else if (currentLevel <= 20)
      {
        int item = random.Next(16, 20);
        return items![item];
      }
      else if (currentLevel <= 25)
      {
        int item = random.Next(21, 25);
        return items![item];
      }
      else if (currentLevel <= 30)
      {
        int item = random.Next(26, 30);
        return items![item];
      }
      else if (currentLevel <= 35)
      {
        int item = random.Next(31, 35);
        return items![item];
      }
      else if (currentLevel <= 40)
      {
        int item = random.Next(36, 40);
        return items![item];
      }
      else if (currentLevel <= 45)
      {
        int item = random.Next(41, 45);
        return items![item];
      }
      else if (currentLevel <= 50)
      {
        int item = random.Next(46, 50);
        return items![item];
      }
      else if (currentLevel <= 55)
      {
        int item = random.Next(51, 55);
        return items![item];
      }
      else if (currentLevel <= 60)
      {
        int item = random.Next(56, 60);
        return items![item];
      }
      else if (currentLevel <= 65)
      {
        int item = random.Next(61, 65);
        return items![item];
      }
      else if (currentLevel <= 70)
      {
        int item = random.Next(66, 70);
        return items![item];
      }
      else
      {
        int item = random.Next(66, 70);
        return items![item];
      }
    }
  }
}