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
      CreateItem();
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

    public void CreateItem()
    {
      /*
        sword - 15%
        shield - 25%
        potion - 60% (30% health, 30% mana)
      */

      items = new Item[70];

      // lvl 1 - 5
      items[0] = new Item("Sword", 10, "Common", "Weapon");
      items[1] = new Item("Shield", 10, "Common", "Armor");
      items[2] = new Item("Potion Mana", 10, "Common", "Potion");
      items[3] = new Item("Potion Health", 10, "Common", "Potion");

      // lvl 6 - 10
      items[4] = new Item("Sword", 20, "Uncommon", "Weapon");
      items[5] = new Item("Shield", 20, "Uncommon", "Armor");
      items[6] = new Item("Potion Mana", 20, "Uncommon", "Potion");
      items[7] = new Item("Potion Health", 20, "Uncommon", "Potion");

      // lvl 11 - 15
      items[8] = new Item("Sword", 30, "Rare", "Weapon");
      items[9] = new Item("Shield", 30, "Rare", "Armor");
      items[10] = new Item("Potion Mana", 30, "Rare", "Potion");
      items[11] = new Item("Potion Health", 30, "Rare", "Potion");

      // lvl 16 - 20
      items[12] = new Item("Sword", 40, "Epic", "Weapon");
      items[13] = new Item("Shield", 40, "Epic", "Armor");
      items[14] = new Item("Potion Mana", 40, "Epic", "Potion");
      items[15] = new Item("Potion Health", 40, "Epic", "Potion");

      // lvl 21 - 25
      items[16] = new Item("Sword", 50, "Legendary", "Weapon");
      items[17] = new Item("Shield", 50, "Legendary", "Armor");
      items[18] = new Item("Potion Mana", 50, "Legendary", "Potion");
      items[19] = new Item("Potion Health", 50, "Legendary", "Potion");

      // lvl 26 - 30
      items[20] = new Item("Sword", 60, "Mythic", "Weapon");
      items[21] = new Item("Shield", 60, "Mythic", "Armor");
      items[22] = new Item("Potion Mana", 60, "Mythic", "Potion");
      items[23] = new Item("Potion Health", 60, "Mythic", "Potion");

      // lvl 31 - 35
      items[24] = new Item("Sword", 70, "Godly", "Weapon");
      items[25] = new Item("Shield", 70, "Godly", "Armor");
      items[26] = new Item("Potion Mana", 70, "Godly", "Potion");
      items[27] = new Item("Potion Health", 70, "Godly", "Potion");

      // lvl 36 - 40
      items[28] = new Item("Sword", 80, "Divine", "Weapon");
      items[29] = new Item("Shield", 80, "Divine", "Armor");
      items[30] = new Item("Potion Mana", 80, "Divine", "Potion");
      items[31] = new Item("Potion Health", 80, "Divine", "Potion");

      // lvl 41 - 45
      items[32] = new Item("Sword", 90, "Infernal", "Weapon");
      items[33] = new Item("Shield", 90, "Infernal", "Armor");
      items[34] = new Item("Potion Mana", 90, "Infernal", "Potion");
      items[35] = new Item("Potion Health", 90, "Infernal", "Potion");

      // lvl 46 - 50
      items[36] = new Item("Sword", 100, "Celestial", "Weapon");
      items[37] = new Item("Shield", 100, "Celestial", "Armor");
      items[38] = new Item("Potion Mana", 100, "Celestial", "Potion");
      items[39] = new Item("Potion Health", 100, "Celestial", "Potion");

      // lvl 51 - 55
      items[40] = new Item("Sword", 110, "Astral", "Weapon");
      items[41] = new Item("Shield", 110, "Astral", "Armor");
      items[42] = new Item("Potion Mana", 110, "Astral", "Potion");
      items[43] = new Item("Potion Health", 110, "Astral", "Potion");

      // lvl 56 - 60
      items[44] = new Item("Sword", 120, "Cosmic", "Weapon");
      items[45] = new Item("Shield", 120, "Cosmic", "Armor");
      items[46] = new Item("Potion Mana", 120, "Cosmic", "Potion");
      items[47] = new Item("Potion Health", 120, "Cosmic", "Potion");

      // lvl 61 - 65
      items[48] = new Item("Sword", 130, "Universal", "Weapon");
      items[49] = new Item("Shield", 130, "Universal", "Armor");
      items[50] = new Item("Potion Mana", 130, "Universal", "Potion");
      items[51] = new Item("Potion Health", 130, "Universal", "Potion");

      // lvl 66 - 70
      items[52] = new Item("Sword", 140, "Eternal", "Weapon");
      items[53] = new Item("Shield", 140, "Eternal", "Armor");
      items[54] = new Item("Potion Mana", 140, "Eternal", "Potion");
      items[55] = new Item("Potion Health", 140, "Eternal", "Potion");
    }
  }
}