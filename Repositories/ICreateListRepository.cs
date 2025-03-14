using Web.Models;

namespace Web.Repositories
{
    public interface ICreateListRepository
    {
        Task<TaskList> CreateTask(TaskList task);
        Task<List<TaskList>> GetList();
        Task<TaskList> GetById(Guid Id);
        Task<TaskList> UpdateTask(TaskList task);
        Task<TaskList> DeleteTask(Guid Id);
    }
}
