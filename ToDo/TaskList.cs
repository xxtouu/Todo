using System.Runtime.CompilerServices;

namespace Todo;
public class TaskList
{
    private List<Task> Tasks = new();
    public TaskList(){}
    public TaskList(IEnumerable<Task> taskArray)
    {
        foreach (var item in taskArray)
        {
            Tasks.Add(new(item));
        }
    }

    public void AddTask(string title)
    {
        bool isTask = FindTask(title).Item1;
        if (isTask)
        {
            Tasks.Add(new Task(title));
        }
    } 

    private void DeleteTask(string title)
    {
        bool isTask = FindTask(title).Item1;
        if (isTask)
        {
            int index = FindTask(title).Item2;
            Tasks.RemoveAt(index);
        }
    }

    private (bool,int) FindTask(string title)
    {
        int index =0;
        foreach(var task in Tasks)
        {
            if(task.Title.ToLower() == title.ToLower())
                return (true,index);
            index++;
        }
        return (false,-1);
    }

    public void MarkInProgress(string title)
    {
        bool isTask = FindTask(title).Item1;
        if (isTask)
        {
            int index = FindTask(title).Item2;
            Tasks[index].Status = "In Progress";
        }
    }

    public void MarkDone(string title)
    {
        bool isTask = FindTask(title).Item1;
        if (isTask)
        {
            int index = FindTask(title).Item2;
            Tasks[index].Status = "Done";
        }
    }

    public void RemoveDone()
    {
        for (int i = Tasks.Count - 1; i >= 0; i--)
        {
            if (Tasks[i].Status == "Done")
            {
                Tasks.RemoveAt(i);
            }
        }
    }

    public override string ToString()
    {
        System.Text.StringBuilder res = new();
        foreach(var item in Tasks)
        {
            res.Append(item);
        }
        return res.ToString();
    }
}