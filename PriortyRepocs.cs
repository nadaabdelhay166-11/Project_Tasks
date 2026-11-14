public class PriortyRepo
{
    OurContext context = new OurContext();

    public List<Priorty> GetAll()
    {
        return context.priorties.ToList();
    }

    public void Add(Priorty p)
    {
        context.Add(p);
        context.SaveChanges();
    }
}
