using System.Security.Claims;
using AllReady.ViewModels;
using MediatR;

namespace AllReady.Features.Event
{
    public class ShowEventQuery : IRequest<EventViewModel>
    {
        public int EventId { get; set; }
        public ClaimsPrincipal User { get; set; }
    }
}