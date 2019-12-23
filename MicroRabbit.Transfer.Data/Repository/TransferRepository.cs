﻿using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDBContext _ctx;

        public TransferRepository(TransferDBContext ctx)
        {
            this._ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
