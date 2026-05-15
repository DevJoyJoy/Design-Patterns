public class EventManager
{
    List<IInscrito> inscritos = [];

    public void AtivaSininho()
    {
        foreach(var i in inscritos)
            i.Update();
    }
    public void Inscrever(IInscrito insc)
    => inscritos.Add(insc);
}