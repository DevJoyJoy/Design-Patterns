public class EventManager
{
    private Dictionary<string, List<IAdventure>> adventures = new Dictionary<string,List<IAdventure>>();

    public void AddAdventure(string typeAdventure, IAdventure adventure)
    {
        adventures[typeAdventure].Add(adventure);
    }

    public void AttackBoss(string typeAdventure, IBoss enemy)
    {
        foreach(var adv in adventures[typeAdventure])
            adv.Attack();
    }


}