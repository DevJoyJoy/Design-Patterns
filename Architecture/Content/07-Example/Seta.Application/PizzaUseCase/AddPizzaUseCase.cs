namespace Seta.Application.PizzaUseCases;

public class AddPizzaUseCase(
    IPizzaService service
)
{
    public void Do(PizzaDTO pizza)
    {
        if (pizza.Name.Count() < 3)
        {
            Console.WriteLine("Nome curto!");
            return;
        }
        
        service.AdicionarPizza(pizza);
    }
}