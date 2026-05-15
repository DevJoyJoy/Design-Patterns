namespace SOFactory;

public class LinuxFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("LinuxButton criado com sucesso!");
        return new WindowsButton();
    }

    public ICheckbox CreateCheckBox()
    {
        Console.WriteLine("LinuxBox criado com sucesso!");
        return new LinuxBox();
    }
}