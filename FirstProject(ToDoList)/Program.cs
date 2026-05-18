Console.WriteLine("Welcome To Task Tracker App \n");
Console.Write("please Enter The size of Tasks You want to Add it : ");
int size = int.Parse(Console.ReadLine());
List<string> Tasks = new List<string>();


while (true)
{
    Console.WriteLine("Chosse Number to Chosse what you want to do from (1-6).");
    Console.WriteLine("1- Add Task");
    Console.WriteLine("2- View Tasks");
    Console.WriteLine("3- Delete Task");
    Console.WriteLine("4- Update Task");
    Console.WriteLine("5- Exit \n \n");
    Console.Write("please Enter Your Choice: ");
    int userchoice = int.Parse(Console.ReadLine());
    switch (userchoice)
    {
        case 1:
            AddTask();
            break;
        case 2:
            ViewTasks();
            break;
        case 3:
            DeleteTask();
            break;
        case 4:
            UpdateTask();
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}

void AddTask()
{
    if(Tasks.Count >= size)
    {
        Console.WriteLine("You have reached the maximum number of tasks you can add.");
        return;
    }
    Console.Write("please enter the task Name :");
    string task = Console.ReadLine();
    Tasks.Add(task);
}
void ViewTasks()
{
    Console.WriteLine("Your Tasks ");
    for(int i=0;i<Tasks.Count; i++)
    {
        Console.WriteLine(Tasks[i]);
    }
}
void DeleteTask()
{
    Console.Write("Please Enter The Name Of The Task You Want To Delete : ");
    int  index = int.Parse(Console.ReadLine());
    if(index>=0 && index < Tasks.Count)
    {
        Tasks.RemoveAt(index);
        Console.WriteLine("Task Deleted Successfully");
    }
    else
    {
        Console.WriteLine("Task Not Found");
    }
}

void UpdateTask()
{
    Console.Write("Please Enter The Task Name You Want To Update :");
    int index = int.Parse(Console.ReadLine());
    if (index >= 0 && index < Tasks.Count)
    {
        Console.WriteLine("Please Enter The New Name Of The Task : ");
        string newTaskName = Console.ReadLine();
      
        Tasks[index] = newTaskName;
        Console.WriteLine("Task Updated Successfully");
    }
    else
    {
        Console.WriteLine("Task Name Not Found, please try again.");
    }
}

