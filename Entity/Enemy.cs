namespace RPG
{
  class Enemy
  {
    // Proprieties
    private string name;
    private int health;
    private int strength;
    private int xp;
    private int goldDrop;

    // Constructor
    public Enemy(string name, int health, int strength, int goldDrop, int xp)
    {
      this.name = name;
      this.health = health;
      this.strength = strength;
      this.goldDrop = goldDrop;
      this.xp = xp;
    }

    // Public Methods
    public bool Damage(int strength)
    {
      this.health -= strength;
      if (this.health <= 0)
      {
        Console.WriteLine("You killed the " + name + "!");
        Console.WriteLine("You got " + goldDrop + " gold!");
        Console.WriteLine("You got " + xp + " experience!");
        DropGold();
        return true;
      }
      else
      {
        return false;
      }
    }

    public int DropGold()
    {
      return goldDrop;
    }

    public int DropXP()
    {
      return xp;
    }

    public int Strength
    {
      get { return strength; }
    }
    // Shows
    public void ShowName()
    {
      Console.WriteLine("Enemy Name: " + name);
      Console.WriteLine("Enemy Health: " + health);
      Console.WriteLine("Enemy Strength: " + strength);
    }

    public void StatusCombat()
    {
      Console.WriteLine("Enemy Name: " + name);
      Console.WriteLine("Enemy Health: " + health);
    }
  }
}