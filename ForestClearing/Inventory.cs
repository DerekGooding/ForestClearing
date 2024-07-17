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
            string? result = ReadLine();
            MenuOption? pick = options.Find(x => x.Key.Equals(result, StringComparison.OrdinalIgnoreCase));
            if (pick != null)
            {
                pick.Invoke();
            }
            else if (string.IsNullOrEmpty(result))
            {
                WriteLine("I do not understand that.");
            }
            else
            {
                name = result;
            }
        }
        return name;
    }
}