public interface ICarroCombustivel
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
    void Estacionar();
    void VerificarGasolina();
    void Ligar();
    void Desligar();
}