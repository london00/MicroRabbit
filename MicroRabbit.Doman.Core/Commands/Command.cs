using MicroRabbit.Doman.Core.Events;
using System;

namespace MicroRabbit.Doman.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
