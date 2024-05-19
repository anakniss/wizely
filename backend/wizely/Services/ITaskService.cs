namespace wizely.Services;

public interface ITaskService
{
    IEnumerable<Task> GetAllTasks();
    Task GetTaskById(int id);
    void AddTask(Task task);
    void UpdateTask(Task task);
    void DeleteTask(int id);
}