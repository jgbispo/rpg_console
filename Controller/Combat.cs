namespace RPG
{

  class Combat
  {
    public static bool Battle(int dice, Player player, Enemy enemy, bool isBattle)
    {
      Console.Clear();
      if (dice == 20)
      {
        Console.WriteLine("You critical hit the enemy!");
        Console.WriteLine("You did " + player!.Strength * 2 + " damage!");
        if (enemy.Damage(player.Strength * 2))
        {
          player.Gold += enemy.DropGold();
          player.Experience += enemy.DropXP();
          isBattle = !isBattle;
          return isBattle;
        }
      }
      else if (dice <= 3)
      {
        Console.WriteLine("You missed!");
        Console.WriteLine("You critical took " + enemy.Strength * 2 + " damage!");
        player.Damage(enemy.Strength * 2);
        Console.WriteLine("You got " + player.Health + " health!");
      }
      else if (dice >= 10)
      {
        Console.WriteLine("You hit the enemy!");
        Console.WriteLine("You did " + player!.Strength + " damage!");
        if (enemy.Damage(player.Strength))
        {
          player.Gold += enemy.DropGold();
          player.Experience += enemy.DropXP();
          isBattle = !isBattle;
          return isBattle;
        }
      }
      else
      {
        Console.WriteLine("You missed!");
        Console.WriteLine("You took " + enemy.Strength + " damage!");
        player.Damage(enemy.Strength);
        Console.WriteLine("You got " + player.Health + " health!");
      }
      return isBattle;
    }

    public static bool Run(int dice, bool isBattle, Enemy enemy, Player player)
    {
      Console.Clear();
      if (dice >= 10)
      {
        Console.WriteLine("You escaped!");
        isBattle = !isBattle;
        return isBattle;
      }
      else
      {
        Console.WriteLine("You couldn't escape!");
        Console.WriteLine("You took " + enemy.Strength + " damage!");
        player.Damage(enemy.Strength);
        Console.WriteLine("You got " + player.Health + " health!");
      }
      return isBattle;
    }
  }
}