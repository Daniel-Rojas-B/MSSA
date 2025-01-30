using System.ComponentModel;

namespace Mod3Enumdemo
{
    enum Seasons
    {
        Winter =1, 
        Spring,
        Summer,
        Fall
    }
    enum ErrorCodes
    {
        Not_found = 400,
        Internal_Server_Error
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFavSeason(Seasons.Spring);
            List<ToDo> todolist = new List<ToDo>();
            todolist.Add(new ToDo() { TaskId = 1, Description = "Study for test", EstimatedHours = 1.5f, TaskStatus = Status.NotStarted });

            ToDo mytodo = new ToDo();
            mytodo.TaskId = 2;
            mytodo.Description = "Do challenge labs";
            mytodo.EstimatedHours = 3.5f;
            mytodo.TaskStatus = Status.Completed;
            todolist.Add (mytodo);

            todolist.Add(new ToDo() { TaskId = 3, Description = "Menthor calls", EstimatedHours = 2.0f, TaskStatus = Status.Missed });
            todolist.Add(new ToDo() { TaskId = 4, Description = "Build a resume", EstimatedHours = 5.0f, TaskStatus = Status.InProgress });
            todolist.Add(new ToDo() { TaskId = 5, Description = "Download VS", EstimatedHours = 0.5f, TaskStatus = Status.Completed });

            //System.IO.FileStream obj = new FileStream("", FileMode.Append);
            
            PrintList(todolist);

            Console.ReadKey();
        }
        static void PrintFavSeason(Seasons favseason)
        {
            int val = (int)favseason;           
            Console.WriteLine($"Your favorite season is: {favseason} - {val}");
            
        }
        static void PrintList(List<ToDo> todos)
        {
            foreach(var todo in todos)
            {
                switch(todo.TaskStatus)
                {
                    case Status.Missed:
                        Console.ForegroundColor = ConsoleColor.Red; break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green; break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Blue; break;
                    default: Console.ForegroundColor = ConsoleColor.White; break;
                }
                Console.WriteLine($"{todo.TaskId}, {todo.Description}, {todo.EstimatedHours} ({todo.TaskStatus})");
            }
        }
    }
}
