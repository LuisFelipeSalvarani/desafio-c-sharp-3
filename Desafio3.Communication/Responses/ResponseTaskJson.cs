using Desafio3.Communication.Enums;
using TaskStatus = Desafio3.Communication.Enums.TaskStatus;

namespace Desafio3.Communication.Responses;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStatus Status { get; set; }
}
