using Microsoft.AspNetCore.Mvc;
using wizely.Services;

namespace wizely.Controllers;

public class TaskController(ITaskService taskService) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Task>> GetAllTasks()
    {
        return Ok(taskService.GetAllTasks());
    }

    [HttpGet("{id}")]
    public ActionResult<Task> GetTaskById(int id)
    {
        return Ok(taskService.GetTaskById(id));
    }

    [HttpPost]
    public IActionResult AddTask(Task task)
    {
        taskService.AddTask(task);
        return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, Task task)
    {
        if(id != task.Id)
        {
            return BadRequest();
        }
        taskService.UpdateTask(task);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        taskService.DeleteTask(id);
        return NoContent();
    }
}