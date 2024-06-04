class Task
{
   public string Title { get; set; }
   public string TaskDescription { get; set; }
   int id { get; set; }

    public Task(string title, string description)
    {
        Console.WriteLine("please enter a title/name for your task");
        Title = Console.ReadLine();

        Console.WriteLine($"please enter a {Title} task description");
        TaskDescription = Console.ReadLine();

    }
}