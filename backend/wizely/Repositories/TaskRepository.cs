using wizely.Data;

namespace wizely.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly DataContext _context;

    public TaskRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Task> GellAllTasks()
    {
        return _context.Tasks.ToList();
    }

    public Task GetTaskById(int id)
    {
        return _context.Tasks.FirstOrDefault(t => t.Id == id);
    }

    public void AddTask(Task task)
    {
        _context.Tasks.Add(task);
    }

    public void UpdateTask(Task task)
    {
        throw new NotImplementedException();
    }

    public void DeleteTask(int id)
    {
        throw new NotImplementedException();
    }
}