using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class School(string name) : IObserver
    {
        private string _name = name;
        public void Update(string news)
        {
            Console.WriteLine($"School {_name} received news:   { news}");
        }
    }
}
