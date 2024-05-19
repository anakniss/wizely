namespace wizely.Repositories;

public interface ITaskRepository
{
    IEnumerable<Task> GellAllTasks();
    Task GetTaskById(int id);
    void AddTask(Task task);
    void UpdateTask(Task task);
    void DeleteTask(int id);
}