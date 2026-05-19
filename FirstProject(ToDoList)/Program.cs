Console.WriteLine("Welcome To Task Tracker App ");
Console.WriteLine("------------------------------------------");
int size;

Console.Write("Please Enter The Maximum Number Of Tasks: ");

while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
{
    Console.Write("Invalid Input, Please Enter A Valid Number: ");
}

List<string> Tasks = new List<string>();

Console.WriteLine("------------------------------------------");
while (true)
{
    Console.WriteLine("Chosse Number to Chosse what you want to do from (1 to 6) .");
    Console.WriteLine("1- Add Task");
    Console.WriteLine("2- View Tasks");
    Console.WriteLine("3- Delete Task");
    Console.WriteLine("4- Update Task");
    Console.WriteLine("5- Complete Task;");
    Console.WriteLine("6- Exit");
    Console.WriteLine("------------------------------------------");
    Console.Write("Please Enter Your Choice: ");

    int userChoice;

    if (!int.TryParse(Console.ReadLine(), out userChoice))
    {
        Console.WriteLine("Invalid Input");
        continue;
    }

    switch (userChoice)
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
            MarkComplete();
            break;
        case 6:
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
    Console.Write("please Enter task title:");
    string task = Console.ReadLine();
    Tasks.Add(task);
    Console.WriteLine($"Task Added");
}
void ViewTasks()
{
    Console.WriteLine("Your Tasks ");
    for(int i=0;i<Tasks.Count; i++)
    {
        Console.WriteLine($"Task {i+1}: {Tasks[i]}");
    }
}
void DeleteTask()
{
    if (Tasks.Count == 0)
    {
        Console.WriteLine("No Tasks To Delete");
        return;
    }

    ViewTasks();

    Console.Write("Please Enter The Task Number You Want To Delete: ");

    int index;

    if (!int.TryParse(Console.ReadLine(), out index))
    {
        Console.WriteLine("Invalid Input");
        return;
    }

    index--;

    if (index >= 0 && index < Tasks.Count)
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
    if (Tasks.Count == 0)
    {
        Console.WriteLine("No Tasks To Update");
        return;
    }

    ViewTasks();

    Console.Write("Please Enter The Task Number You Want To Update: ");

    int index;

    if (!int.TryParse(Console.ReadLine(), out index))
    {
        Console.WriteLine("Invalid Input");
        return;
    }

    index--;

    if (index >= 0 && index < Tasks.Count)
    {
        Console.Write("Please Enter The New Task Name: ");

        string newTaskName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newTaskName))
        {
            Console.WriteLine("Task Name Cannot Be Empty");
            return;
        }

        Tasks[index] = newTaskName;

        Console.WriteLine("Task Updated Successfully");
    }
    else
    {
        Console.WriteLine("Task Not Found");
    }
}
void MarkComplete()
{
    if (Tasks.Count == 0)
    {
        Console.WriteLine("No Tasks Found");
        return;
    }

    ViewTasks();

    Console.Write("Please Enter The Task Number You Want To Mark As Complete: ");

    int index;

    if (!int.TryParse(Console.ReadLine(), out index))
    {
        Console.WriteLine("Invalid Input");
        return;
    }

    index--;

    if (index >= 0 && index < Tasks.Count)
    {
        Console.WriteLine($"Task \"{Tasks[index]}\" Marked As Complete");
    }
    else
    {
        Console.WriteLine("Task Not Found");
    }
}