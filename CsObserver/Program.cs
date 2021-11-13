using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter("Jorge", 100, 25);
            ObserverInterface observer = new PlayerObserver();
            player.Subscribe(observer);
            player.Life = 99;
            player.Name = "German";
            player.Years = 40;
            player.Name = "Segismundo";
            player.Years = 55;
            player.Life = 56;
            Console.ReadKey();

        }
    }
}
