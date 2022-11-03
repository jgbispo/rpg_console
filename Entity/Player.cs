namespace RPG
{
  class Player
  {
    // Proprieties
    private string name;
    private int health;
    private int maxHealth;
    private int mana;
    private int maxMana;
    private int strength;
    private int magic;
    private int gold;
    private int experience;
    private int level;
    private int defense;
    private string classPlayer;

    // Constructor
    public Player(string name, string classPlayer)
    {
      this.name = name;
      this.health = 100;
      this.maxHealth = 100;
      this.mana = 100;
      this.maxMana = 100;
      this.gold = 0;
      this.experience = 0;
      this.level = 1;
      this.classPlayer = classPlayer;

      if (classPlayer == "warrior")
      {
        this.strength = 10;
        this.magic = 5;
        this.defense = 10;
      }
      else if (classPlayer == "mage")
      {
        this.strength = 5;
        this.magic = 10;
        this.defense = 5;
      }
      else
      {
        this.strength = 5;
        this.magic = 5;
        this.defense = 5;
      }
    }

    // Public Methods
    public void Status()
    {
      Console.Clear();
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Class: " + classPlayer);
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

    public void Staff(int magic)
    {
      this.health -= magic;
    }

    public void LevelUp()
    {
      level++;
      maxHealth += 10;
      maxMana += 10;
      strength += 5;
      magic += 5;
      Console.Clear();
      Console.WriteLine("You leveled up!");
      Console.WriteLine("You are now level " + level);
      Console.WriteLine("Up Health: " + health);
      Console.WriteLine("Up Mana: " + mana);
      Console.WriteLine("Up Strength: " + strength);
      Console.WriteLine("Up Magic: " + magic);
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

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

    public int MaxHealth
    {
      get { return maxHealth; }
    }

    public int Mana
    {
      get { return mana; }
      set { mana = value; }
    }

    public int MaxMana
    {
      get { return maxMana; }
    }

    public int Strength
    {
      get { return strength; }
    }

    public int Magic
    {
      get { return magic; }
    }

    public string ClassPlayer
    {
      get { return ClassPlayer; }
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