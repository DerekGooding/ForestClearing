using ForestClearing.Model;

namespace ForestClearing.Helpers;

public static class MenuHelper
{
    public static void CallMenu(List<MenuOption> options)
    {
        while (true)
        {
            Write("Command: ");
            string? response = ReadLine();
            MenuOption? pick = options.Find(x => x.Key.Equals(response, StringComparison.OrdinalIgnoreCase));
            pick?.Invoke();

            WriteLine("I do not understand that command.");
        }
    }

    public static IEnumerable<MenuOption> DefaultOptions => [ new("inventory", Main.DisplayInventory), new("help", Main.Help), ];

    public static IEnumerable<MenuOption> SameResult(string[] keys, Action effect) => keys.Select(x => new MenuOption(x, effect));
}
