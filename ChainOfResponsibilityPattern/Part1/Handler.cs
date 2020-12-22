using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part1
{
    public class Handler
    {
        Handler next;
        int id;
        public int Limit { get; set; }

        public Handler(int id ,Handler handler)
        {
            this.id = id;
            Limit = id * 1000;
            next = handler;

        }
        public string HandlerRequest(int data)
        {
            if (data< Limit)
            {
                return $"Request for {data} handler at level {id}";

            }
            else if (next !=null)
            {
                return next.HandlerRequest(data);
            }
            else
            {
                return $"Request for {data} handler by default at level";
            }
        }
    }
}
