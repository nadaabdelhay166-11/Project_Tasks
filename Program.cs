using System.Data;

class Program
{
    static void Main()
    {
        int choice;
        Console.Write("Enter Choice (1 to Exit, any other number to Add): ");
        choice = int.Parse(Console.ReadLine());

        
        List<Task> t = new List<Task>();
        Task s = new Task();
        
        while (choice != 1)
        {
            
            Console.WriteLine("Enter The info of Task:");

            Console.Write("Name: ");
            s.name = Console.ReadLine();

            Console.Write("Start Task: ");
            s.Start = DateTime.Parse(Console.ReadLine());

            Console.Write("End Task: ");
            s.End = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter if Task is Completed: ");
            s.IsCompleted = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter User Name:");
            s.User.name = Console.ReadLine();
            Console.WriteLine("Enter Birth Year:");
            DateOnly d = new DateOnly (2008,1,1);
            s.User.brith = d;
            s.User.Account_status
            t.Add(s);

            Console.Write("Enter 1 to Exit : ");
            choice = int.Parse(Console.ReadLine());
        }

        
        TaskRepo t1 = new TaskRepo();
        t1.AddTask(s);
        
    }

}


