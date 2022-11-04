namespace RPG
{
  class Shop
  {
    private Item[]? items;
    private List<int> prices = new List<int>();
    private List<string> itemToSold = new List<string>();
    private Player? player;

    public Shop(Player player)
    {
      Console.WriteLine("Welcome to the shop!");
      Console.WriteLine("Items renew each time they come to the shop, so enjoy!");
      Console.Write("Press any key to continue...");
      Console.ReadKey();
      this.player = player;
      items = Items.CreateItem(items!);
      for (int i = 0; i < items.Length; i++)
      {
        prices.Add(items[i].GetValue() * 10);
      }
      for (int i = 0; i < 5; i++)
      {
        Random random = new Random();
        int index = random.Next(0, items!.Length);
        Console.WriteLine();
        itemToSold.Add(i + 1 + " - " + items[index].GetName() + " - " + prices[index] + " golds" + " - " + items[index].GetRarity());
      }
      ShopMenu();
    }

    public void ShopMenu()
    {
      Console.Clear();
      Console.WriteLine("Shop - Main");
      Console.Write("Choose an option (buy / sell): ");
      string option = Console.ReadLine()!;
      switch (option)
      {
        case "buy":
          Console.Write("BUY");
          ShowItems();
          break;
        case "sell":
          Sell();
          break;
        case "exit":
          Console.Clear();
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid option");
          Console.Write("Press any key to continue...");
          Console.ReadKey();
          ShopMenu();
          break;
      }
    }

    public void ShowItems()
    {
      Console.Clear();
      Console.WriteLine("Shop - Buy");
      Console.WriteLine("Items: ");
      for (int i = 0; i < itemToSold.Count; i++)
      {
        Console.WriteLine(itemToSold[i]);
      }
      Console.Write("Choose an item to buy: ");
      int option = int.Parse(Console.ReadLine()!);
      BuyItem(option - 1);
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    public void BuyItem(int index)
    {
      bool isBought = player!.Gold >= prices[index];
      if (isBought)
      {
        InventoryControl.AddItem(player, items![index]);
        player.Gold = player.Gold - prices[index];
        itemToSold.RemoveAt(index);
        prices.RemoveAt(index);
        Console.Clear();
        Console.WriteLine("Item bought");
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        ShopMenu();
      }
      else
      {
        Console.WriteLine("You don't have enough gold");
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        ShopMenu();
      }
    }

    public void Sell()
    {
      Console.Clear();
      Console.WriteLine("Shop - Sell");
      Console.WriteLine("Items: ");
      for (int i = 0; i < InventoryControl.GetSize(player!); i++)
      {
        Console.WriteLine(i + 1 + " - " + InventoryControl.GetItem(player!, i).GetName());
      }
      Console.Write("Choose an item to sell: ");
      int option = int.Parse(Console.ReadLine()!);
      SellItem(option - 1);
    }

    public void SellItem(int index)
    {
      Console.WriteLine("Are you sure you want to sell " + InventoryControl.GetItem(player!, index).GetName() + "?");
      Console.Write("Choose an option: ");
      string option = Console.ReadLine()!;
      switch (option)
      {
        case "yes":
          player!.Gold = player.Gold + (InventoryControl.GetItem(player, index).GetValue() * 10);
          InventoryControl.RemoveItem(player, index);
          Console.Clear();
          Console.WriteLine("Item sold");
          Console.Write("Press any key to continue...");
          Console.ReadKey();
          ShopMenu();
          break;
        case "no":
          Console.Clear();
          Console.WriteLine("Item not sold");
          Console.Write("Press any key to continue...");
          Console.ReadKey();
          ShopMenu();
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid option");
          Console.Write("Press any key to continue...");
          Console.ReadKey();
          ShopMenu();
          break;
      }

    }
  }
}