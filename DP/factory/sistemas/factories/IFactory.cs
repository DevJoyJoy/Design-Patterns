namespace SOFactory;
public interface IFactory
{
    public IButton CreateButton();
    public ICheckbox CreateCheckBox();
}