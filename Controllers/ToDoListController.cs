using Azure;
using Microsoft.AspNetCore.Mvc;
using Web.Application;
using Web.Dto;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly ICreateListUseCase _create;

        public ToDoListController(ICreateListUseCase create)
        {
            _create = create;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var res = await _create.GetList();

            return Created("", res);
        }


        [HttpPost]
        public async Task<IActionResult> CreateTask(TaskListRequired required)
        {
            var task =  await _create.CreateTask(required);

            if(required.Title == "")
            {
                throw new ArgumentNullException("Campo título é obrigatório.");
            }
            
            return Created("", task);
        }


        [HttpPost("/{Id}")]
        public async Task<IActionResult> EditTask(Guid Id, TaskListEditRequired task)
        {
            var res = await _create.UpdateTask(Id, task);

            return Created("", res);
        }


        [HttpDelete("/{Id}")]
        public async Task<IActionResult> DeleteTask(Guid Id)
        {
            var task = await _create.DeleteTask(Id);
            return Created("", task);
        }
    }

}
