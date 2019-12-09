using MicroRabbit.Doman.Core.Commands;
using MicroRabbit.Doman.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Doman.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Suscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
