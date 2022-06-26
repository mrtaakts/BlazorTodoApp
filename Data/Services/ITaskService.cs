using TodoApp.Data.Models;

namespace TodoApp.Data.Services
{
    public interface ITaskService
    {
        List<TaskModel> GetTaskList();
        void ChangeStatus(Guid id);
        int  RemoveTask(Guid id);
        int AddTask(TaskModel task);
    }
}
