namespace SOFactory;

public class MacFactory: IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("MacButton criado com sucesso!");
        return new MacButton();
    }

    public ICheckbox CreateCheckBox()
    {
        Console.WriteLine("MacBox criado com sucesso!");
        return new MacBox();
    }
}