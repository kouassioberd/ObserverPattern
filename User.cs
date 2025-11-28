using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class User(string name) : IObserver
    {
        private string _name = name;
        public void Update(string news)
        {
            Console.WriteLine($"User {_name} received news:   { news}");
        }
    }
}
