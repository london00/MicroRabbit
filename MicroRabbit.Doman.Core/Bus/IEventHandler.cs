using MicroRabbit.Doman.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Doman.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {
    }
}
