using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsObserver
{
    public interface ObservedInterface
    {
        void Subscribe(ObserverInterface observer);
        void Unsubscribe(ObserverInterface observer);
        void Notify();
        State GetState();
    }
}
