using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsObserver
{
    public class PlayerObserver : ObserverInterface
    {
        public void Update(State newState)
        {
            Console.WriteLine("*************Se actualizo el observado***********");
            Console.WriteLine("Name: " + newState.Name);
            Console.WriteLine("Life: " + newState.Life);
            Console.WriteLine("Years: " + newState.Years);
        }
    }
}
