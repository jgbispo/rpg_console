namespace RPG
{
  class Inventory
  {
    private List<Item> items;
    public Inventory()
    {
      items = new List<Item>();
    }

    public void ShowInventory()
    {
      Console.Clear();
      Console.WriteLine("Inventory");
      Console.WriteLine("Items: ");
      for (int i = 0; i < items.Count; i++)
      {
        Console.WriteLine(i + 1 + " - " + items[i].GetName());
      }
    }

    public void ShowStats(int index)
    {
      items[index].ShowStats();
    }

    public void AddItem(Item item)
    {
      items.Add(item);
    }

    public void RemoveItem(int index)
    {
      items.RemoveAt(index);
    }

    public Item GetItem(int index)
    {
      return items[index];
    }

    public int GetSize()
    {
      return items.Count;
    }
  }
}