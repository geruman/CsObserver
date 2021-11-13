namespace CsObserver
{
    public class State
    {
        public State(int years, int life, string name)
        {
            Years = years;
            Life = life;
            Name = name;
        }

        public int Years { get; }
        public int Life { get; }
        public string Name { get; }
    }
}