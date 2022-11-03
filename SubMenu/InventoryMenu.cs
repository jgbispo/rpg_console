namespace RPG
{
  class InventoryMenu
  {
    public static void ChooseOptionInventory(Player player)
    {
      Console.Write("Choose an option: ");
      string option = Console.ReadLine()!;
      switch (option)
      {
        case "show stats":
          Console.Clear();
          Console.Write("Choose an item: ");
          int index = int.Parse(Console.ReadLine()!) - 1;
          InventoryControl.ShowStats(player, index);
          break;
        case "drop":
          Console.Clear();
          Console.Write("Choose an item: ");
          int index3 = int.Parse(Console.ReadLine()!) - 1;
          InventoryControl.RemoveItem(player, index3);
          break;
        case "exit":
          Console.Clear();
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid option!");
          break;
      }
    }
  }
}