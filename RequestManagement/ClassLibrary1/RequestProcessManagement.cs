using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestHandler
{
    public class RequestProcessManagement : IRequestProcessManagement, IUserManagement
    {
        public bool AddRequest(object requestDetails)
        {
            ProcessHandler.Instance.AddToQ(requestDetails);
            // Retrieve the product from the database based on rquestdetails
            return true;//Will be based on process status, currently given true
        }

        public bool CancelRequest(object requestDetails)
        {
            throw new NotImplementedException();
        }

        public object GetRequestStatus(object requestId)
        {
            throw new NotImplementedException();
        }

        public object GetUserHistoryDetails()
        {
            throw new NotImplementedException();
        }

        public bool Login(object userDetails)
        {
            throw new NotImplementedException();
        }

        public bool LogOut(object userDetails)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(object userDetails)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRequest(object requestDetails)
        {
            throw new NotImplementedException();
        }
    }
}
