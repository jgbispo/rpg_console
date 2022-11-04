namespace RPG
{
  class Items
  {
    public static Item[] CreateItem(Item[] items)
    {
      /*
        sword - 15%
        shield - 25%
        potion - 60% (30% health, 30% mana)
      */

      items = new Item[56];

      // lvl 1 - 5
      items[0] = new Item("Sword", 10, "Common", "Weapon");
      items[1] = new Item("Shield", 10, "Common", "Armor");
      items[2] = new Item("Potion Mana", 10, "Common", "Potion");
      items[3] = new Item("Potion Health", 10, "Common", "Potion");

      // lvl 6 - 10
      items[4] = new Item("Sword", 20, "Uncommon", "Weapon");
      items[5] = new Item("Shield", 20, "Uncommon", "Armor");
      items[6] = new Item("Potion Mana", 20, "Uncommon", "Potion");
      items[7] = new Item("Potion Health", 20, "Uncommon", "Potion");

      // lvl 11 - 15
      items[8] = new Item("Sword", 30, "Rare", "Weapon");
      items[9] = new Item("Shield", 30, "Rare", "Armor");
      items[10] = new Item("Potion Mana", 30, "Rare", "Potion");
      items[11] = new Item("Potion Health", 30, "Rare", "Potion");

      // lvl 16 - 20
      items[12] = new Item("Sword", 40, "Epic", "Weapon");
      items[13] = new Item("Shield", 40, "Epic", "Armor");
      items[14] = new Item("Potion Mana", 40, "Epic", "Potion");
      items[15] = new Item("Potion Health", 40, "Epic", "Potion");

      // lvl 21 - 25
      items[16] = new Item("Sword", 50, "Legendary", "Weapon");
      items[17] = new Item("Shield", 50, "Legendary", "Armor");
      items[18] = new Item("Potion Mana", 50, "Legendary", "Potion");
      items[19] = new Item("Potion Health", 50, "Legendary", "Potion");

      // lvl 26 - 30
      items[20] = new Item("Sword", 60, "Mythic", "Weapon");
      items[21] = new Item("Shield", 60, "Mythic", "Armor");
      items[22] = new Item("Potion Mana", 60, "Mythic", "Potion");
      items[23] = new Item("Potion Health", 60, "Mythic", "Potion");

      // lvl 31 - 35
      items[24] = new Item("Sword", 70, "Godly", "Weapon");
      items[25] = new Item("Shield", 70, "Godly", "Armor");
      items[26] = new Item("Potion Mana", 70, "Godly", "Potion");
      items[27] = new Item("Potion Health", 70, "Godly", "Potion");

      // lvl 36 - 40
      items[28] = new Item("Sword", 80, "Divine", "Weapon");
      items[29] = new Item("Shield", 80, "Divine", "Armor");
      items[30] = new Item("Potion Mana", 80, "Divine", "Potion");
      items[31] = new Item("Potion Health", 80, "Divine", "Potion");

      // lvl 41 - 45
      items[32] = new Item("Sword", 90, "Infernal", "Weapon");
      items[33] = new Item("Shield", 90, "Infernal", "Armor");
      items[34] = new Item("Potion Mana", 90, "Infernal", "Potion");
      items[35] = new Item("Potion Health", 90, "Infernal", "Potion");

      // lvl 46 - 50
      items[36] = new Item("Sword", 100, "Celestial", "Weapon");
      items[37] = new Item("Shield", 100, "Celestial", "Armor");
      items[38] = new Item("Potion Mana", 100, "Celestial", "Potion");
      items[39] = new Item("Potion Health", 100, "Celestial", "Potion");

      // lvl 51 - 55
      items[40] = new Item("Sword", 110, "Astral", "Weapon");
      items[41] = new Item("Shield", 110, "Astral", "Armor");
      items[42] = new Item("Potion Mana", 110, "Astral", "Potion");
      items[43] = new Item("Potion Health", 110, "Astral", "Potion");

      // lvl 56 - 60
      items[44] = new Item("Sword", 120, "Cosmic", "Weapon");
      items[45] = new Item("Shield", 120, "Cosmic", "Armor");
      items[46] = new Item("Potion Mana", 120, "Cosmic", "Potion");
      items[47] = new Item("Potion Health", 120, "Cosmic", "Potion");

      // lvl 61 - 65
      items[48] = new Item("Sword", 130, "Universal", "Weapon");
      items[49] = new Item("Shield", 130, "Universal", "Armor");
      items[50] = new Item("Potion Mana", 130, "Universal", "Potion");
      items[51] = new Item("Potion Health", 130, "Universal", "Potion");

      // lvl 66 - 70
      items[52] = new Item("Sword", 140, "Eternal", "Weapon");
      items[53] = new Item("Shield", 140, "Eternal", "Armor");
      items[54] = new Item("Potion Mana", 140, "Eternal", "Potion");
      items[55] = new Item("Potion Health", 140, "Eternal", "Potion");

      return items;
    }
  }
}