using Desafio3.Application.UseCase.Delete;
using Desafio3.Application.UseCase.GetAll;
using Desafio3.Application.UseCase.GetById;
using Desafio3.Application.UseCase.Register;
using Desafio3.Application.UseCase.Update;
using Desafio3.Communication.Requests;
using Desafio3.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Desafio3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestRegisterTaskJson request)
        {
            var useCase = new RegisterTaskUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            var useCase = new GetAllTasksUseCase();

            var response = useCase.Execute();

            if (response.Tasks.Count != 0)
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var useCase = new GetTaskByIdUseCase();

            var response = useCase.Execute(id);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskByIdUseCase();

            useCase.Execute(id);

            return NoContent();
        }
    }
}
