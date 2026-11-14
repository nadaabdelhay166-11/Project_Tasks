using Microsoft.EntityFrameworkCore;

class UserRepo
{
    OurContext context = new OurContext();

    public List<User> GetAll()
    {
        return context.Users.ToList();
    }

    public void Add(User u)
    {
        context.Users.Add(u);
        context.SaveChanges();
    }
    public List<User> Age2000()
    {
        var x = context.Users.Where(s => s.brith.Year > 2000);
        return x.ToList();

    }
}
