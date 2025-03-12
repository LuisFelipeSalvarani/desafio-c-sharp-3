using Desafio3.Communication.Requests;
using Desafio3.Communication.Responses;

namespace Desafio3.Application.UseCase.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestRegisterTaskJson request)
    {
        return new ResponseRegisteredTaskJson
        {
            Id = 13,
            Name = request.Name,
        };
    }
}
