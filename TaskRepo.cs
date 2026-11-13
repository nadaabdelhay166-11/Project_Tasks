
class TaskRepo
{
     OurContext Context = new OurContext();
    public bool AddTask(Task task)
    {
        Context.Tasks.Add(task);
        return Context.SaveChanges()>0;
    }
    public bool DeleteTask(int id)
    {
        Task? t = Context.Tasks.Find(id);
        
        if (t != null)
        {
            Context.Tasks.Remove(t);
            Context.SaveChanges();
            return true;
        }
        else
        {
            return false;
        }

    }
    public List<Task> task()
   {

        return Context.Tasks.ToList();

   }
    public bool Update(int id, Task task)
    {
        Task? t = Context.Tasks.Find(id);
        
        if(t != null)
        {
            Context.Tasks.Update(t);
            Context.SaveChanges();
            return true;
        }
        else
        {
            return false;
        }

    }
    public List<Task> task(int id)
    {
        Context.SaveChanges();
        return Context.Tasks.ToList();

    }
    public List<User> Age2000 ()
    {
        var x = Context.Users.Where(s => s.brith.Year > 2000);
        return x.ToList();

    }
  public List<Task> taskF()
    {
        var x = Context.Tasks.Where(e => e.IsCompleted == false).ToList();
        return x;
    }
    public List<Task> taskT()
    {
        var x = Context.Tasks.Where(e => e.IsCompleted == true).ToList();
        return x;
    }
    public List<Task> taskE(DateTime t)
    {

        var x = Context.Tasks.Where(e => e.End != t).ToList();
        return x;
    }
    
    public Task? GetTask(int id)
    {
        Task? s = Context.Tasks.Find(id);
          if(s!=null)
        {
            return s;
        }
        else
        {
            return null;
        }
    }
    public List<Task> Alltask()
    {
        return Context.Tasks.ToList();
    }
}
    
    
 
