namespace ForestClearing.Model;

public class MenuOption(string key, Action effect)
{
    public string Key { get; } = key;
    public Action Effect { get; } = effect;
    public void Invoke() => Effect.Invoke();
}
