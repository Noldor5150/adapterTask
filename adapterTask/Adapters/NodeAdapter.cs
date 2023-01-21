using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTask.Adapters
{
    class NodeAdapter : IAdapter
    {
        public string Name;

        public NodeAdapter()
        {
            Name = "NodeAdapter";
        }

        public bool MakeCall(string url)
        {
            Console.WriteLine($"{Name} is making a call to {url}");
            return true;
        }
    }
}
