using BlazorState;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TestBlazorState.Features.Counter
{
    public partial class CounterState
    {
        public class IncrementCounterHandler : ActionHandler<IncrementCounterAction>
        {
            CounterState CounterState => Store.GetState<CounterState>();
            public override Task<Unit> Handle(IncrementCounterAction aAction, CancellationToken aCancellationToken)
            {
                CounterState.Counter += aAction.Amount;
                return Unit.Task;
            }
            public IncrementCounterHandler(IStore store) : base(store) { }
        }
    }
}
