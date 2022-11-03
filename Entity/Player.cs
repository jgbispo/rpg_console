namespace RPG
{
  class Player
  {
    // Proprieties
    private string name;
    private int health;
    private int mana;
    private int strength;
    private int gold;
    private int experience;
    private int level;

    // Constructor
    public Player(string name)
    {
      this.name = name;
      health = 100;
      mana = 100;
      strength = 10;
      gold = 0;
      experience = 0;
      level = 1;
    }

    // Public Methods
    public void Status()
    {
      Console.Clear();
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Health: " + health);
      Console.WriteLine("Mana: " + mana);
      Console.WriteLine("Strength: " + strength);
      Console.WriteLine("Gold: " + gold);
      Console.WriteLine("Experience: " + experience);
      Console.WriteLine("Level: " + level);
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    public void StatusCombat()
    {
      Console.Clear();
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Health: " + health);
    }

    public void ShowInventory()
    {
      Console.Clear();
      Console.WriteLine("Inventory");
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    public void Damage(int strength)
    {
      this.health -= strength;
    }

    public void LevelUp()
    {
      level++;
      health += 10;
      mana += 10;
      strength += 5;
    }
    // Private Methods

    // Getters and Setters
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Health
    {
      get { return health; }
      set { health = value; }
    }

    public int Mana
    {
      get { return mana; }
      set { mana = value; }
    }

    public int Strength
    {
      get { return strength; }
    }

    public int Gold
    {
      get { return gold; }
      set { gold = value; }
    }

    public int Experience
    {
      get { return experience; }
      set { experience = value; }
    }

    public int Level
    {
      get { return level; }
      set { level = value; }
    }
  }
}