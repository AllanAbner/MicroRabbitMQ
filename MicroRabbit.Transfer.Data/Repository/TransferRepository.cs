﻿using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext transferDbContext;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            this.transferDbContext = transferDbContext;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferDbContext.TransferLog;
        }
            
    }
}