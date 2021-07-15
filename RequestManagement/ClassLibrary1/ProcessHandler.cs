using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RequestHandler
{
    internal class ProcessHandler
    {
        #region Private
        private static readonly ProcessHandler instance;
        private ConcurrentQueue<object> concurrentQueue;

        private ProcessHandler()
        {
            concurrentQueue = new ConcurrentQueue<object>();
        }

        #endregion

        #region Public 
        public static ProcessHandler Instance
        {
            get
            {
                if(instance== null)
                {
                    return new ProcessHandler();
                }
                return instance;
            }
        }

        public bool AddToQ(object request)
        {
            concurrentQueue.Enqueue(request);
            //Monitor shall be enabled to watch the request
            return true;//Currently return true , will change based on process
        }

        public bool UpdateRequestInQ(object request)
        {
            // Currently return true , will change based on process
            return true;
        }

        public bool RemoveRequestInQ(object request)
        {
            //Currently return true , will change based on process
            return true;
        }
        #endregion
    }
}
