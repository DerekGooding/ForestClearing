using ForestClearing.Model;

namespace MiniProject;

public static class Inventory
{
    public static void InventoryOne()
    {
        List<string> inventory = ["paperclip", "granola bar"];
        WriteLine($" THIS IS YOUR INVENTORY: ");
        inventory.ForEach(WriteLine);
    }

    public static string PlayerName()
    {
        List<MenuOption> options =
        [
            new("INVENTORY", InventoryOne),
        ];
        string name = string.Empty;
        while (string.IsNullOrEmpty(name))
        {
            Write("What is your name: ");
            string? response = ReadLine();
            MenuOption? pick = options.Find(x => x.Key.Equals(response, StringComparison.OrdinalIgnoreCase));
            if (pick != null)
            {
                pick.Invoke();
            }
            else if (string.IsNullOrEmpty(response))
            {
                WriteLine("I do not understand that.");
            }
            else
            {
                name = response;
            }
        }
        return name;
    }
}