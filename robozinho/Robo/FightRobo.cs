using Robo;

public class FightRobo : IComportamento
{
     public string Execute(Robozin robo)
    {
        var chance = Random.Shared.Next(0, 101);
        if (chance > 0 && chance < 6)
        {
            robo.Comportamento = new HackRobo();
            
        }
        return "Combate...";

    }
}