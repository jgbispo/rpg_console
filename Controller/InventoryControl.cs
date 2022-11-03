namespace RPG
{
  class InventoryControl
  {
    public static void ShowInventory(Player player)
    {
      Inventory inventory = player.Inventory;
      inventory.ShowInventory();
    }
    public static void ShowStats(Player player, int index)
    {
      Inventory inventory = player.Inventory;
      inventory.ShowStats(index);
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
      return inventory.GetSize();
    }
  }
}