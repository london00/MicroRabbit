using MicroRabbit.Doman.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            this._bus = bus;
            this._transferRepository = transferRepository;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return this._transferRepository.GetTransferLogs();
        }
    }
}
