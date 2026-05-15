public interface IAdventure{
    public int Hp { get; set;}
    public int Damage { get; set;}
    public int Attack()
    {
        return Damage;
    }
}