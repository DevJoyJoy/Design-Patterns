public class EventManagerBoss
{
    private Dictionary<string, List<IBoss>> bosses = new Dictionary<string, List<IBoss>>();

    public void CreateBoss(string typeBoss, IBoss boss)
    {
        if (!bosses.ContainsKey(typeBoss))
            bosses.Add(typeBoss, []);

        bosses[typeBoss].Add(boss);
    }

    public void AttackGuilda(string typeBoss, IAdventure enemy)
    {
        foreach(var bss in bosses[typeBoss])
            bss.Attack();
    }
}