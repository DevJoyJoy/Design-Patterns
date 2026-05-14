public class MailMan
{
    public EventManager em { get; set; } = new();

    public void Post(string news)
    {
        em.Notify(news);
    }

    public void Sell()
    {
        em.Notify("Vendi bala");
    }
}