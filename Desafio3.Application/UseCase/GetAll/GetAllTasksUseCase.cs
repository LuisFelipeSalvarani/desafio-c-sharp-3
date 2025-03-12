using Desafio3.Communication.Responses;

namespace Desafio3.Application.UseCase.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseTaskShortJson>
            {
                new ResponseTaskShortJson
                {
                    Id = 1,
                    Name = "Test",
                    Priority = Communication.Enums.TaskPriority.High,
                    Status = Communication.Enums.TaskStatus.Progress
                }
            }
        };
    }
}
