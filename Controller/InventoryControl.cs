namespace RPG
{
  class InventoryControl
  {
    private static bool isTutorialInventory = false;
    public static void ShowInventory(Player player, bool isTutorial)
    {
      Console.Clear();
      if (isTutorial && !isTutorialInventory) { Tutorial.Inventory(); isTutorialInventory = true; }
      Inventory inventory = player.Inventory;
      inventory.ShowInventory();
    }
    public static void ShowItem(Player player, int index)
    {
      Inventory inventory = player.Inventory;
      inventory.ShowItem(index);
    }
    public static void AddItem(Player player, Item item)
    {
      Inventory inventory = player.Inventory;
      inventory.AddItem(item);
    }
    public static void RemoveItem(Player player, int index)
    {
      Inventory inventory = player.Inventory;
      inventory.RemoveItem(index);
    }
    public static Item GetItem(Player player, int index)
    {
      Inventory inventory = player.Inventory;
      return inventory.GetItem(index);
    }
    public static int GetSize(Player player)
    {
      Inventory inventory = player.Inventory;
      return inventory.Items.Count;
    }

    public static int GetMaxSize(Player player)
    {
      Inventory inventory = player.Inventory;
      return inventory.MaxItems;
    }

    public static List<Item> GetItems(Player player)
    {
      Inventory inventory = player.Inventory;
      return inventory.Items;
    }

    public static void EquipItem(Player player, int index)
    {
      Inventory inventory = player.Inventory;
      List<Item> items = inventory.Items;
      foreach (Item i in items)
      {
        if (i.IsEquipped)
        {
          i.IsEquipped = false;
        }
      }
      Item item = inventory.GetItem(index);
      PlayerControl.Equip(player, item);

    }

  }
}