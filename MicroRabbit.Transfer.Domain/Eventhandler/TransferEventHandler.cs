using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Eventhandler
{
    public class TransferEventHandler : IEventHandler<TranferCreatedEvent>
    {
        private readonly ITransferRepository transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            this.transferRepository = transferRepository;
        }

        public Task Handle(TranferCreatedEvent @event)
        {
            return transferRepository.Add(new Models.TransferLog
            {
                Amount = @event.Amount,
                FromAccount = @event.From,
                ToAccount = @event.To
            });


        }
    }
}