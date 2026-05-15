public class EventManager
{
    private Dictionary<string, List<IUser>> Users = new Dictionary<string, List<IUser>>();

    public void Notify(string news)
    {
        if(!Users.ContainsKey(news))
            throw new Exception("Não tem...");
        foreach(var u in Users[news])
            u.BuyNews(news);
    }
    public void Inscrever(string news, IUser user)
    {
        if (!Users.ContainsKey(news))
            Users.Add(news, []);

        Users[news].Add(user);
    }
}