using adapterTask.Adapters;
using System;

namespace adapterTask
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpRequester requester = new HttpRequester(new NodeAdapter());
            HttpRequester requester1 = new HttpRequester(new AjaxAdapter());
            requester.Fetch("Google.com");
            requester1.Fetch("YAhoo.com");
            Console.ReadKey();
        }
    }
}
