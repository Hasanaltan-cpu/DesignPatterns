using ObjectPoolPattern.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pool Size {0}", ClientPool.Instance.Size);
            Console.WriteLine("Getting Client class");
            var client1 = ClientPool.Instance.AcquireObject();
            client1.Connect();

            Console.WriteLine("Giving Back to Client");
            if (client1 !=null)
            {
                ClientPool.Instance.ReleaseObject(client1);
            }
            var clients = new List<ClientPool>();
            for (int i = 0; i < ClientPool.Instance.Size; i++)
            {
                clients.Add(ClientPool.Instance.AcquireObject());
            }
            Console.WriteLine("All objects of Clients got added to List.");
            var nullClient = ClientPool.Instance.AcquireObject();
            if (nullClient==null)
            {
                Console.WriteLine("There is not Client class");

            }
            Console.WriteLine("Getting increase pool size");
            ClientPool.Instance.IncreaseSize();

            Console.WriteLine("Getting new Client class");
            var newClient = ClientPool.Instance.AcquireObject();

            newClient.Connect();

            foreach (var item in clients)
            {
                ClientPool.Instance.ReleaseObject(item);
            }
        }
    }
}
