using BlazorState;

namespace TestBlazorState.Features.Counter
{
    public partial class CounterState : State<CounterState>
    {
        public int Counter { get; set; }
        public override void Initialize() => Counter = 3;
    }
}
