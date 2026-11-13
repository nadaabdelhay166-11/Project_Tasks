using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;

class Program
{
    static void Main()
    {
        int choice;
        Console.Write("Enter Choice (1 to Exit, any other number to Continue): ");
        choice = int.Parse(Console.ReadLine());

        List<TaskItem> t = new List<TaskItem>();
        TaskItem s = new TaskItem();
        
        while (choice != 1)
        {
            
            Console.WriteLine("Enter The info of Task:");

            Console.Write("Name: ");
            s.name = Console.ReadLine();
            Console.Write("ID: ");
            s.id = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Enter Account_status:");
            s.User.Account_status = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account_Type:");
            s.User.Account_Type = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type Filed:");
            s.filed.type = Console.ReadLine();
            Console.WriteLine("Enter ID Filed:");
            s.filed.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type Priorty:");
            s.Priorty.type = Console.ReadLine();
            Console.WriteLine("Enter ID  Priorty:");
            s.Priorty.id = int.Parse(Console.ReadLine());
            t.Add(s);
            TaskRepo repo = new TaskRepo();

            Console.Write("Enter 1 to Exit : ");
            choice = int.Parse(Console.ReadLine());
            
            if (s.User.Account_status==true)
            {
                Console.Write("Enter 10 to Add Function for Admin : ");
                int value;
                value = int.Parse(Console.ReadLine());
                Console.WriteLine("if you Need Add Task Enter 2 :");
               if(value==2)
                {
                    repo.AddTask(s);
                }
                Console.WriteLine("if you Need Delete Task Enter 4 :");
                if (value == 4)
                {
                    int id_del;
                    Console.WriteLine("Enter id for Delete Task:");
                    id_del = int.Parse(Console.ReadLine());
                    repo.DeleteTask(id_del);
                }
                Console.WriteLine("if you Need Read Task Enter 6 :");
                if(value==6)
                {
                    repo.task();
                }
                Console.WriteLine("if you Need Update Task Enter 8 :");
                if(value==8)
                {
                    int id_Up;
                    Console.WriteLine("Enter id for Update Task:");
                    id_Up = int.Parse(Console.ReadLine());
                    repo.Update(id_Up,s);
                }
                Console.WriteLine("if you Need Task is not Completion Enter 10 :");
                if (value == 10)
                {
                    
                    
                    repo.taskF();
                }
                Console.WriteLine("if you Need Task is Completion Enter 12 :");
                if (value == 12)
                {


                    repo.taskT();
                }
                Console.WriteLine("if you Need Users BirthYear order to 2000 Enter 14 :");
                if (value == 12)
                {


                    repo.Age2000();
                }
                //taskE(DateTime t)
                DateTime n = new DateTime();
                Console.WriteLine("if you Need DateTime task is Complete Enter 16 :");
                n = DateTime.Parse(Console.ReadLine());
                if(value==16)
                {
                    repo.taskE(n);
                }
                //GetTask(int id)

                Console.WriteLine("if you Need certion task  Enter 18:");
                Console.WriteLine("Enter id");
                int id_sp;
                id_sp = int.Parse(Console.ReadLine());
                if(value==18)
                {
                    repo.GetTask(id_sp);

                }
                Console.WriteLine("if you Need All task  Enter 20:");
                if(value==20)
                {
                    repo.Alltask();
                }

            }
            else
            {

            }
        }

        
        
        
    }

}


