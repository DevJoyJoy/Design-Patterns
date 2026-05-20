using Seta.Application;
using Seta.Application.PizzaUseCase;
using Seta.Application.PizzaUseCases;
using Seta.Infrastructure;

var addUseCase = new AddPizzaUseCase(new PizzaService());
var cutPizzaUseCase  = new CortarPizzaUseCase(new PizzaService());
var  verQuantia = new GetQuantidadeUseCase(new PizzaService());

while (true)
{
    Console.WriteLine(@"
        1- Adicionar Pizza
        2- Cortar Pizza
        3- Ver quantidade
    ");

    var op= Console.ReadLine();
    if(op is null)
        continue;

    switch (op)
    {
        case "1":
            Console.WriteLine("Nome:\n>>");
            var nome = Console.ReadLine();
            Console.WriteLine("Sabor:\n>>");
            var sabor = Console.ReadLine();
            Console.WriteLine("Fatias:\n>> 1");
            var fatias = 1;

            PizzaDTO pizza = new (
                nome!,
                sabor!,
                fatias!
            );

            addUseCase.Do(pizza);
            break;
        case "2":
            break;
        case "3":
            break;
        default:
            break;
    }
}