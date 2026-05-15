namespace SOFactory;

public class WindowsFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("WindowsButton criado com sucesso!");
        return new WindowsButton();
    }

    public ICheckbox CreateCheckBox()
    {
        Console.WriteLine("WindowsBox criado com sucesso!");
        return new WindowsBox();
    }
}