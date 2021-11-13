namespace CsObserver.Tests
{
    internal class DummyObserver : ObserverInterface
    {
        public int Years { get; set; }
        public int Life { get; set; }
        public string Name { get; set; }

        public void Update(State newState)
        {
            Years = newState.Years;
            Life = newState.Life;
            Name = newState.Name;
        }
    }
}