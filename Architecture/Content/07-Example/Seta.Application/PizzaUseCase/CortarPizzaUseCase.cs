namespace Seta.Application.PizzaUseCase;

public class CortarPizzaUseCase
(
    IPizzaService service
)
{
    public void Do()
    {
        service.CortarPizza();
    }
}