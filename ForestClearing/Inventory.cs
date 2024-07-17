namespace MiniProject;

public static class Inventory
{
    public static void InventoryOne()
    {
        List<string> inventory = new List<string>();
        inventory.Add("paperclip");
        inventory.Add("granola bar");
        Console.WriteLine($" THIS IS YOUR INVENTORY: ");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }
    }
    public static string PlayerName()
    {
        string name;
        bool playerName = false;
        do
        {
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("I do not understand that.");
            }
            else if (name == "INVENTORY")
            {
                Inventory.InventoryOne();
            }
            else
            {
                playerName = true;
                return name;
            }
        } while (!playerName);
        return null;
    }
}
