namespace RPG
{

  class Combat
  {
    public static bool Battle(int dice, Player player, string attack, Enemy enemy, bool isBattle)
    {
      Console.Clear();
      int damage = 0;
      if (attack == "sword")
      {
        damage = player.Strength;
      }
      else if (attack == "magic")
      {
        damage = player.Magic;
        player.Mana -= 10;
      }
      else
      {
        damage = (player.Strength + player.Magic) / 2;
      }

      if (dice == 20)
      {
        Console.WriteLine("You critical hit the enemy!");
        Console.WriteLine("You did " + damage * 2 + " damage!");
        if (enemy.Damage(damage * 2))
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
        PlayerControl.Damage(enemy.Strength * 2, player);
        Console.WriteLine("You got " + player.Health + " health!");
      }
      else if (dice >= 10)
      {
        Console.WriteLine("You hit the enemy!");
        Console.WriteLine("You did " + damage + " damage!");
        if (enemy.Damage(damage))
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
        PlayerControl.Damage(enemy.Strength, player);
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
        PlayerControl.Damage(enemy.Strength, player);
        Console.WriteLine("You got " + player.Health + " health!");
      }
      return isBattle;
    }

    public static bool UsePotionHealth(int dice, bool isBattle, Enemy enemy, Player player)
    {
      Console.Clear();
      if (dice >= 10)
      {
        Console.WriteLine("You used a potion!");
        if (player.Health <= player.MaxHealth)
        {
          player.Health += (player.MaxHealth * 10) / 100;
          if (player.Health > player.MaxHealth)
          {
            player.Health = player.MaxHealth;
          }
          Console.WriteLine("You got " + player.Health + " health!");
        }
        else
        {
          Console.WriteLine("You have a full life!");
          Console.WriteLine("You got " + player.Health + " health!");
        }
      }
      else
      {
        Console.WriteLine("You couldn't use a potion!");
        Console.WriteLine("You took " + enemy.Strength + " damage!");
        PlayerControl.Damage(enemy.Strength, player);
        Console.WriteLine("You got " + player.Health + " health!");
      }
      return isBattle;
    }

    public static bool UsePotionMana(int dice, bool isBattle, Enemy enemy, Player player)
    {
      Console.Clear();
      if (dice >= 10)
      {
        Console.WriteLine("You used a potion!");
        if (player.Mana <= player.MaxMana)
        {
          player.Mana += (player.MaxMana * 10) / 100;
          if (player.Mana > player.MaxMana)
          {
            player.Mana = player.MaxMana;
          }
          Console.WriteLine("You got " + player.Mana + " mana!");
        }
        else
        {
          Console.WriteLine("You have a full mana!");
          Console.WriteLine("You got " + player.Mana + " mana!");

        }
      }
      else
      {
        Console.WriteLine("You couldn't use a potion!");
        Console.WriteLine("You took " + enemy.Strength + " damage!");
        PlayerControl.Damage(enemy.Strength, player);
        Console.WriteLine("You got " + player.Mana + " mana!");
      }
      return isBattle;
    }
  }
}