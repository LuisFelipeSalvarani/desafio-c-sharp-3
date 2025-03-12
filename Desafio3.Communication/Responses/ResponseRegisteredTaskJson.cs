using Desafio3.Communication.Enums;
using TaskStatus = Desafio3.Communication.Enums.TaskStatus;

namespace Desafio3.Communication.Responses;

public class ResponseRegisteredTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
