using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsObserver
{
    public class PlayerCharacter : ObservedInterface
    {
        private List<ObserverInterface> observers;
        private int years;
        private int life;
        private string name;
        public List<ObserverInterface>GetObservers()
        {
            return observers;
        }
        public PlayerCharacter(string name, int life, int years)
        {
            this.observers = new List<ObserverInterface>();
            this.name = name;
            this.life = life;
            this.years = years;
        }
        
        public int Years { 
            get {
                return years;
            }
            set { 
                years = value; 
                Notify(); 
            } 
        }
        public int Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
                Notify();
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                Notify();
            }
        }
        public State GetState()
        {
            return new State(Years, Life, Name);
        }

        public void Notify()
        {
            foreach(ObserverInterface observer in observers)
            {
                observer.Update(GetState());
            }
        }

        public void Subscribe(ObserverInterface observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(ObserverInterface observer)
        {
            observers.Remove(observer);
        }
    }
}
