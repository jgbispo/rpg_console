namespace RPG
{
  class InventoryMenu
  {
    public static void ChooseOptionInventory(Player player)
    {
      int index;
      Console.Clear();
      Console.Write("Choose an option: ");
      string option = Console.ReadLine()!;
      switch (option)
      {
        case "show":
          Console.Write("Choose an item: ");
          index = Convert.ToInt32(Console.ReadLine()) - 1;
          InventoryControl.ShowItem(player, index);
          ChooseOptionInventory(player);
          break;
        case "drop":
          Console.Write("Choose an item: ");
          index = Convert.ToInt32(Console.ReadLine()) - 1;
          Console.WriteLine("Are you sure you want to drop this item?");
          string answer = Console.ReadLine()!;
          if (answer == "yes" || answer == "y")
          {
            InventoryControl.RemoveItem(player, index);
            Console.WriteLine("Item dropped");
          }
          ChooseOptionInventory(player);
          break;
        case "exit":
          Console.Clear();
          break;
        default:
          Console.WriteLine("Invalid option!");
          ChooseOptionInventory(player);
          break;
      }
    }
  }
}