namespace Todo;
public class Task
{
    private string _title = "Unknown";
    public string Status{get; set;} = "Undone";
    public string Title
    {
        get => _title;
        set
        {
            if (char.IsLower(value[0]) && value !="")
            {
                _title = char.ToUpper(value[0]) + value[1..];
                return;
            }
            _title = value;
            
        }
    }

    public Task(string title)
    {
        Title = title;
    }

    public Task(Task other)
    {
        Title = other.Title;
        Status = other.Status;
    }

    public override string ToString()
    {
        return $"*Title: {Title} | Status: {Status}\n";
    }
    
}
