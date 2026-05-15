public class EventManager
{
    private Dictionary<string, List<IAdventure>> adventures = new Dictionary<string,List<IAdventure>>();

    public void AddAdventure(string typeAdventure, IAdventure adventure)
    {
        if(!adventures.ContainsKey(typeAdventure))
            adventures.Add(typeAdventure, []);
        adventures[typeAdventure].Add(adventure);
    }

    public void AttackBoss(string typeAdventure, IAdventure enemy)
    {
        foreach(var adv in adventures[typeAdventure])
            adv.Attack();
    }

    private Dictionary<string, List<IAdventure>> bosses = new Dictionary<string, List<IAdventure>>();

    public void CreateBoss(string typeBoss, IAdventure boss)
    {
        if (!bosses.ContainsKey(typeBoss))
            bosses.Add(typeBoss, []);

        bosses[typeBoss].Add(boss);
    }

    public void AttackGuilda(string typeBoss)
    {
        foreach(var bss in bosses[typeBoss])
            bss.Attack();
    }

}