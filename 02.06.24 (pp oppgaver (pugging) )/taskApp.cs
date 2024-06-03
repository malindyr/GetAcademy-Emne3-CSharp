/*Konsollbasert ToDo liste
Lag en todo app! Du skal kunne legge til oppgaver, slette dem og gå inn på en task for å se beskrivelse eller flere detaljer*/

/*klasser 
 
to do app
user
list Tasks

addTask()
removeTask()
viewTask()



tasks
 */

class TaskApp
{
    List<Task> Tasks { get; set; }

    public TaskApp()
    {
        Tasks = new List<Task>();
    }

    public void TaskMenu()
    {
        Console.WriteLine("What would you like to do? press corresponding number \r\n 1.Add Task \r\n 2.Remove task \r\n 3.View tasks");
            
    }

    public void AddTask(Task task)
    {
        Tasks.Add(task);
    }

    public void ViewTasks()
    {
        int i = 1;
        foreach (var task in Tasks)
        {
            i++;
            Console.WriteLine($"\r\n {i}. task name{task.Title} \r\n task description {task.TaskDescription}");
        }
    }

    public void RemoveTask(){
    
    }
}