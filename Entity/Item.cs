namespace RPG
{
  class Item
  {
    private string name;
    private int value;
    private int rarity;
    private string type;

    public Item(string name, int value, int rarity, string type)
    {
      this.name = name;
      this.value = value;
      this.rarity = rarity;
      this.type = type;
    }

    public void ShowStats()
    {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Value: " + value);
      Console.WriteLine("Rarity: " + rarity);
      Console.WriteLine("Type: " + type);
    }

    public string GetName()
    {
      return name;
    }

    public int GetValue()
    {
      return value;
    }

    public int GetRarity()
    {
      return rarity;
    }

    public string GetTypeItem()
    {
      return type;
    }

    public void SetName(string name)
    {
      this.name = name;
    }

    public void SetValue(int value)
    {
      this.value = value;
    }

    public void SetRarity(int rarity)
    {
      this.rarity = rarity;
    }

    public void SetType(string type)
    {
      this.type = type;
    }
  }
}