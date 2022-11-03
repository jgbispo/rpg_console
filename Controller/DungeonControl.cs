namespace RPG
{
  class DungeonControl
  {
    // Proprieties
    private Enemy[] enemies = new Enemy[5];
    private Player? player;

    public void Dungeon(Player player)
    {
      Console.Clear();
      this.player = player;
      PrizeDraw();
    }

    private void PrizeDraw()
    {
      Random random = new Random();
      int prize = random.Next(1, 101);

      if (prize <= 50)
      {
        Walk();
      }
      else if (prize <= 80)
      {
        Fight();
      }
      else if (prize <= 95)
      {
        Fight();
      }
      else
      {
        Walk();
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
          case "attack":
            Console.Clear();
            Console.WriteLine("You chosen attack...");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            isBattle = Combat.Battle(dice, player!, enemy, isBattle);
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
      for (int i = 0; i < enemyCount; i++)
      {
        int enemyType = random.Next(0, 5);
        switch (enemyType)
        {
          case 0:
            return enemies[i] = new Enemy("Goblin", 10, 2, 5, 10);
          case 1:
            return enemies[i] = new Enemy("Orc", 15, 3, 10, 15);
          case 2:
            return enemies[i] = new Enemy("Skeleton", 20, 4, 15, 20);
          case 3:
            return enemies[i] = new Enemy("Zombie", 25, 5, 20, 25);
          case 4:
            return enemies[i] = new Enemy("Dragon", 30, 6, 25, 30);
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


    private void Loot()
    {
      // TODO: Implement logic
    }
  }
}