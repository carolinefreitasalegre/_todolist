using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Web.Domain.Context;
using Web.Models;

namespace Web.Repositories
{
    public class CreateListRepository : ICreateListRepository
    {

        private readonly AppDbContext _context;

        public CreateListRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TaskList> CreateTask(TaskList task)
        {
            await _context.lists.AddAsync(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskList> DeleteTask(Guid Id)
        {

            var task = await GetById(Id);

            if (task == null)
            {
                throw new Exception("Não encontrado");
            }
            _context.lists.Remove(task);
            await _context.SaveChangesAsync();

            return task;


        }

        public async Task<TaskList> GetById(Guid Id)
        {
            var task = await _context.lists.FindAsync(Id);

            if (task == null)
            {
                throw new Exception("Não encontrado");
            }

            return task;
        }

        public async Task<List<TaskList>> GetList()
        {
            return await _context.lists.ToListAsync();
        }

        public async Task<TaskList> UpdateTask(TaskList task)
        {
           _context.lists.Update(task);
            await _context.SaveChangesAsync();

            return task;
        }
    }
}
