using PlayerInput;

public static class ServiceLocator
{
    private static IInput _input;

    public static void Initialize(IInput input)
    {
        _input = input;
    }
    
    public static IInput Input() => _input ??= new EngineInput();
}