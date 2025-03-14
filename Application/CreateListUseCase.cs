using Microsoft.AspNetCore.Http.HttpResults;
using Web.Dto;
using Web.Models;
using Web.Repositories;

namespace Web.Application
{
    public class CreateListUseCase : ICreateListUseCase
    {

        private readonly ICreateListRepository _repository;

        public CreateListUseCase(ICreateListRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TaskList>> GetList()
        {
            return await _repository.GetList();
        }

        public async Task<TaskList> CreateTask(TaskListRequired required)
        {

            var task = new TaskList()
            {
                Id = Guid.NewGuid(),
                Title = required.Title,
                Description = required.Description,
                Status = Entities.Status.Pending,
                CreatedAt = DateTime.UtcNow,
            };





            return await _repository.CreateTask(task);
            
        }

        
        public Task<TaskList> GetTaskById(Guid Id)
        {
            throw new NotImplementedException();
        }

        
        public async Task<TaskList> UpdateTask(Guid Id, TaskListEditRequired task)
        {
            var taskChange = await _repository.GetById(Id);

            if (task == null)
            {
                throw new Exception("Task não encontrada");
            }

            taskChange.Title = task.Title;
            taskChange.Description = task.Description;
            taskChange.Status = task.Status;

            return await _repository.UpdateTask(taskChange);

        }

        public async Task<TaskList> DeleteTask(Guid Id)
        {
            var task = await _repository.GetById(Id);

            if (task == null) {
                throw new Exception("Task não encontrada");
            };

            return await _repository.DeleteTask(Id);

        }

    }
}


/*
 
Regras de Negócio
O título é obrigatório. 
 
*/