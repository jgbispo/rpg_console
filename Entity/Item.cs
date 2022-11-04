namespace RPG
{
  class Item
  {
    private string name;
    private int value;
    private string rarity;
    private string type;
    private bool isEquipped;

    public Item(string name, int value, string rarity, string type)
    {
      this.name = name;
      this.value = value;
      this.rarity = rarity;
      this.type = type;
      this.isEquipped = false;
    }

    public void ShowStatus()
    {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Value: " + value);
      Console.WriteLine("Rarity: " + rarity);
      Console.WriteLine("Type: " + type);
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    // Getters and Setters
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Value
    {
      get { return value; }
      set { this.value = value; }
    }

    public string Rarity
    {
      get { return rarity; }
      set { rarity = value; }
    }

    public string Type
    {
      get { return type; }
      set { type = value; }
    }

    public bool IsEquipped
    {
      get { return isEquipped; }
      set { isEquipped = value; }
    }
  }
}