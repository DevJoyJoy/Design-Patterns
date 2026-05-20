using System.ComponentModel.Design;

namespace Seta.Application.PizzaUseCase;

public class GetQuantidadeUseCase(
    IPizzaService service
)
{
    public int Do()
    {
        return service.GetQuantidade();
    }
}