namespace RPG
{
  class Inventory
  {

    private int maxItems;
    private List<Item> items;
    public Inventory(int maxItems)
    {
      items = new List<Item>();
      this.maxItems = maxItems;
    }

    public void ShowInventory()
    {
      Console.Clear();
      int filled = maxItems - items.Count;
      Console.WriteLine($"Inventory {filled} / {maxItems}");
      if (items.Count == 0)
      {
        Console.WriteLine("Inventory is empty");
      }
      else
      {
        Console.WriteLine("Items: ");
        for (int i = 0; i < items.Count; i++)
        {
          Console.WriteLine(i + 1 + " - " + items[i].Name);
        }
      }
    }

    public void ShowItem(int index)
    {
      items[index].ShowStatus();
    }

    public void AddItem(Item item)
    {
      if (items.Count < maxItems)
      {
        items.Add(item);
      }
      else
      {
        Console.WriteLine("Inventory is full");
      }
    }

    public void RemoveItem(int index)
    {
      items.RemoveAt(index);
    }

    public Item GetItem(int index)
    {
      return items[index];
    }

    public List<Item> Items
    {
      get { return items; }
    }

    public int MaxItems
    {
      get { return maxItems; }
      set { maxItems = value; }
    }
  }
}