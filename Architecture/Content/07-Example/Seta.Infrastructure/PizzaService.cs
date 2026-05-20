using Seta.Application;
using Seta.Domain;

namespace Seta.Infrastructure;

public class PizzaService : IPizzaService
{
    List<Pizza> pizzas = [];
    public void AdicionarPizza(PizzaDTO pizza)
    {
        var newPizza = new Pizza
        {
            Name=pizza.Name,
            Sabor=pizza.Sabor,
            Fatias=pizza.Fatias,
        };
        pizzas.Add(newPizza);
    }

    public void CortarPizza()
    {
        Console.WriteLine("Pizza cortada!");
    }

    public int GetQuantidade()
    {
        return pizzas.Count();
    }

    public void ServirPizza()
    {
        Console.WriteLine("Pizza servida!");
    }
}