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
    private int maxItems = 10;
    private Inventory inventory;

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
      this.inventory = new Inventory(maxItems);

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
      set { maxHealth = value; }
      get { return maxHealth; }
    }

    public int Mana
    {
      get { return mana; }
      set { mana = value; }
    }

    public int MaxMana
    {
      set { maxMana = value; }
      get { return maxMana; }
    }

    public int Strength
    {
      set { strength = value; }
      get { return strength; }
    }

    public int Magic
    {
      set { magic = value; }
      get { return magic; }
    }

    public string ClassPlayer
    {
      get { return classPlayer; }
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

    public int Defense
    {
      get { return defense; }
    }

    public Inventory Inventory
    {
      get { return inventory; }
    }

    public int MaxItem
    {
      set { maxItems = value; }
      get { return maxItems; }
    }
  }
}