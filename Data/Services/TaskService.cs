using TodoApp.Data.Models;

namespace TodoApp.Data.Services
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _dbContext;
        public TaskService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public int AddTask(TaskModel task)
        {
            if (!String.IsNullOrEmpty(task.TaskName))
            {
                _dbContext.Add(task);
                int x = _dbContext.SaveChanges();
                return x;
            }
            return 0;
            
        }

        public void ChangeStatus(Guid id)
        {
            var task = _dbContext.Tasks.FirstOrDefault(t => t.Id == id);
            if(task != null)
            _dbContext.Update(task);
            _dbContext.SaveChanges();
        }

        public List<TaskModel> GetTaskList()
        {
            return _dbContext.Tasks.ToList();
        }

        public int RemoveTask(Guid id)
        {
           var task = _dbContext.Tasks.FirstOrDefault(t => t.Id == id);
            if(task != null)
            _dbContext.Remove(task);
            int x =_dbContext.SaveChanges();
            return x;
        }
    }
}
