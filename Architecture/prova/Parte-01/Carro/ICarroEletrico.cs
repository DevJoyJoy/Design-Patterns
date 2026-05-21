public interface ICarroEletrico
{
    void Viajar(string local);
    string CidadeDeOrigem();
    void Acelerar();
    void Frear();
    void Buzinar();
    void AlterarPorta();
    void AlterarJanela();
    void AlterarPortaMalas();
    void LigarRadio();
    void DesligarRadio();
    void AlterarEstacaoRadio(string estacao);
    void AumentarVolumeRadio();
    void DiminuirVolumeRadio();
    void LigarArCondicionado();
    void DesligarArCondicionado();
    void AlterarModoArCondicionado(string modo);
    void Estacionar();
    void VerificarBateria();
    void Ligar();
    void Desligar();
    void AtivarPilotoAutomatico();
    void MedirPressaoDosPneus();
    void AtivarNitro();
}