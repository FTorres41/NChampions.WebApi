using NChampions.Domain.Responses;

namespace NChampions.Domain.Commands.Interfaces
{
    public interface ICommand : MediatR.IRequest<ApiResponse>
    {
    }
}
