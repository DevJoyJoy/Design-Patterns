using SOFactory;

public class Application(IFactory factory)
{
    private IFactory Factory = factory;

    public void Action()
    {
        Factory.CreateButton();
        Factory.CreateCheckBox();
    }
}