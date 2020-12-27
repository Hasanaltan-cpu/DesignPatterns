using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolPattern.Client
{
    public class ClientPool
    {
        private static Lazy<ClientPool> instance = new Lazy<ClientPool>(() => new ClientPool());
        public static ClientPool Instance { get; } = instance.Value;
        public int Size { get { return _currentSize; } }

        public int TotalObject { get { return _counter; } }


        private const int defaultSize = 5;
        private ConcurrentBag<Client> _bag = new ConcurrentBag<Client>();
        private volatile int _currentSize;
        private volatile int _counter;
        private object _LockObject = new object();

        private ClientPool():this(default)
        {

        }
        private ClientPool(int size)
        {
            _currentSize = size;
        }

        public Client AcquireObject()
        {
            if (!_bag.TryTake(out Client item)) // if object is true, it will send object but it is not true it will create a new object.

            {
                lock (_LockObject)
                {
                    if (item==null)
                    {
                        if (_counter>=_currentSize)
                        {
                            return null;
                            item = new RequestClient();
                            _counter++;
                        }
                    }
                }
            }

            return item;

        }

        public void ReleaseObject(Client item) // we give object to system again and they would be ready to use again.
        {
            _bag.Add(item);
        }
        public void IncreaseSize() // With this method we can control objectpool size.
        {
            lock (_LockObject)
            {
                _currentSize++;
            }
        }
    }
}
