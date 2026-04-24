using System.Security.Cryptography;

namespace Robo;

//Criando a classe do robo
public class Robozin(string name, IComportamento comportamento)
{
    //Definindo que meu robo vai ter um comportamento que será definido na sua criação
    public IComportamento Comportamento { get; set; } = comportamento;
    public string Nome {get;set;} = name;
    //Esse método recebe a ação/comportamento realizado pelo robo
    public string Act()
    {
        //Retornando a ação a ser executada
        return Comportamento.Execute(this);
    }
}