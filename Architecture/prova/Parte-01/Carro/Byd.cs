public class Byd() : ICarroEletrico
{
    private PneuDeEstrada pneu = new();
    private Placa placa = new(new(new("londrina")));

    public void Acelerar() 
    => Console.WriteLine("Acelerando..");
    public void AlterarJanela()
    => Console.WriteLine("Abrindo/Fechando janela");
    public void AlterarPorta()
    => Console.WriteLine("Abrindo/Fechando Porta");
    public void AlterarPortaMalas()
    => Console.WriteLine("Abrindo/Fechando PortaMalas");
    public void Buzinar()
    => Console.WriteLine("Bip Bip!!");
    public void Desligar()
    => Console.WriteLine("Zzz...");
    public void Estacionar()
    => Console.WriteLine("Estacionando.");
    public void Frear()
    => Console.WriteLine("Freando");
    public void Ligar()
    => Console.WriteLine("VROOOMM VROOOOMM");
    public void VerificarGasolina()
    => Console.WriteLine("Tanque na metade");
    public void Viajar(string local)
    => Console.WriteLine($"Viajando até {local}");
    public string CidadeDeOrigem()
    => placa.Estado.Cidade.Name;

    public void LigarRadio()
    => Console.WriteLine("Radio ligado");
    public void DesligarRadio()
    => Console.WriteLine("Radio desligado");
    public void AlterarEstacaoRadio(string estacao)
    => Console.WriteLine("Estacao alt... 98 FM");
    public void AumentarVolumeRadio()
        => Console.WriteLine("Volume +1");
    public void DiminuirVolumeRadio()
        => Console.WriteLine("Volume -1");

    //-----------------------------------------------------
    //Carro elétrico
    //-----------------------------------------------------
    public void LigarArCondicionado()
        => Console.WriteLine("Ar ligado!");

    public void DesligarArCondicionado()
        => Console.WriteLine("Ar desligado!");

    public void AlterarModoArCondicionado(string modo)
        => Console.WriteLine("Ar no ", modo, "!");
    public void VerificarBateria()
        => Console.WriteLine("Averiguando bateria...");

    public void AtivarPilotoAutomatico()
        => Console.WriteLine("Piloto automático ligado!");

    public void MedirPressaoDosPneus()
        => Console.WriteLine("Medindo pressão dos pneus...");

    public void AtivarNitro()
        => Console.WriteLine("Nitro ligado!");
}