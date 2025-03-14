using Web.Dto;
using Web.Models;

namespace Web.Application
{
    public interface ICreateListUseCase
    {
        Task<List<TaskList>> GetList();
        Task<TaskList> GetTaskById(Guid Id);
        Task<TaskList> CreateTask(TaskListRequired task);
        Task<TaskList> UpdateTask(Guid Id, TaskListEditRequired task);
        Task<TaskList> DeleteTask(Guid Id);
    }
}
