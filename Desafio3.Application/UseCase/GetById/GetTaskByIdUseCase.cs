using Desafio3.Communication.Responses;

namespace Desafio3.Application.UseCase.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Comer",
            Description = "Comer até 12:30",
            Deadline = new DateTime(year: 2025, month: 1, day: 1),
            Priority = Communication.Enums.TaskPriority.High,
            Status = Communication.Enums.TaskStatus.Progress
        };
    }
}
