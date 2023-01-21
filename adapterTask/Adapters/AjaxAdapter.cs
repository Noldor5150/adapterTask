using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterTask.Adapters
{
    class AjaxAdapter : IAdapter
    {
        public string Name;

        public AjaxAdapter()
        {
            Name = "AjaxAdapter";
        }

        public bool MakeCall(string url)
        {
            Console.WriteLine($"{Name} is making a call to {url}");
            return true;
        }
    }
}
