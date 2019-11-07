using BlazorState;

namespace TestBlazorState.Features.Counter
{
    public partial class CounterState
    {
        public class IncrementCounterAction : IAction
        {
            public int Amount { get; set; }
        }
    }
}
