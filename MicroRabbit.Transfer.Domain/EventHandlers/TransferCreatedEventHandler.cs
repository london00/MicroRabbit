using MicroRabbit.Doman.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferCreatedEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferCreatedEventHandler(ITransferRepository transferRepository)
        {
            this._transferRepository = transferRepository;
        }
         
        public Task Handle(TransferCreatedEvent @event)
        {
            this._transferRepository.Add(new Models.TransferLog
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });

            return Task.CompletedTask;
        }
    }
}
