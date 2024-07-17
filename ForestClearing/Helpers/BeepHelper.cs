namespace ForestClearing.Helpers;

public static class BeepHelper
{
    public static void ClearBeep()
    {
        Beep(800, 40);
        Clear();
    }
}
