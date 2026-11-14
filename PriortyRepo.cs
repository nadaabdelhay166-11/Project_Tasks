public class FiledRepo
{
    OurContext context = new OurContext();

    public List<Filed> GetAll()
    {
        return context.Fileds.ToList();
    }

    public void Add(Filed f)
    {
        context.Fileds.Add(f);
        context.SaveChanges();
    }
}
