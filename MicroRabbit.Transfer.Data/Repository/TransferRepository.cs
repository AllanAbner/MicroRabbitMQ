using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext transferDbContext;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            this.transferDbContext = transferDbContext;
        }

        public Task Add(TransferLog transferLog)
        {
            try
            {
                transferDbContext.AddAsync(transferLog);
                transferDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                ;
            }
            return Task.CompletedTask;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferDbContext.TransferLog;
        }
    }
}