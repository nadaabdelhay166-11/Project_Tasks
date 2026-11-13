
class TaskRepo
{
     OurContext Context = new OurContext();
    public bool AddTask(TaskItem task)
    {
        Context.Tasks.Add(task);
        return Context.SaveChanges()>0;
    }
    public bool DeleteTask(int id)
    {
        TaskItem? t = Context.Tasks.Find(id);
        
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
    public List<TaskItem> task()
   {

        return Context.Tasks.ToList();

   }
    public bool Update(int id, TaskItem task)
    {
        TaskItem? t = Context.Tasks.Find(id);
        
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
    public List<TaskItem> task(int id)
    {
        Context.SaveChanges();
        return Context.Tasks.ToList();

    }
    public List<User> Age2000 ()
    {
        var x = Context.Users.Where(s => s.brith.Year > 2000);
        return x.ToList();

    }
  public List<TaskItem> taskF()
    {
        var x = Context.Tasks.Where(e => e.IsCompleted == false).ToList();
        return x;
    }
    public List<TaskItem> taskT()
    {
        var x = Context.Tasks.Where(e => e.IsCompleted == true).ToList();
        return x;
    }
    public List<TaskItem> taskE(DateTime t)
    {

        var x = Context.Tasks.Where(e => e.End != t).ToList();
        return x;
    }
    
    public TaskItem? GetTask(int id)
    {
        TaskItem? s = Context.Tasks.Find(id);
          if(s!=null)
        {
            return s;
        }
        else
        {
            return null;
        }
    }
    public List<TaskItem> Alltask()
    {
        return Context.Tasks.ToList();
    }
}
    
    
 
