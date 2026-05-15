using Robo;

public class WalkRobo : IComportamento
{
    public string Execute(Robozin robo)
    {
        var chance = Random.Shared.Next(0, 101);
        if (chance > 0 && chance < 6)
        {
            robo.Comportamento = new HackRobo();
        } else if (chance > 5 && chance < 21)
        {
            robo.Comportamento = new FightRobo();
        }
        return "Caminhando...";

    }
}