namespace ForestClearing.Helpers;

public static class BeepHelper
{
    public static void ClearBeep()
    {
        Beep(800, 40);
        Clear();
    }

    public static void WrongDirectionBeep()
    {
        Beep(200, 100);
        WriteLine("You cannot go that way.");
    }
}
