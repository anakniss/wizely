using wizely.Repositories;

namespace wizely.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public IEnumerable<Task> GetAllTasks()
    {
        return _taskRepository.GellAllTasks();
    }

    public Task GetTaskById(int id)
    {
        return _taskRepository.GetTaskById(id);
    }

    public void AddTask(Task task)
    {
        _taskRepository.AddTask(task);
    }

    public void UpdateTask(Task task)
    {
        _taskRepository.UpdateTask(task);
    }

    public void DeleteTask(int id)
    {
        _taskRepository.DeleteTask(id);
    }
}