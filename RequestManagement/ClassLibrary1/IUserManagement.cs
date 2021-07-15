using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestHandler
{
    public interface IUserManagement
    {
        /// <summary>
        /// Fetch user history details
        /// </summary>
        /// <returns>returns object with user history details</returns>
        object GetUserHistoryDetails();

        /// <summary>
        /// Register user details
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>
        bool RegisterUser(object userDetails);

        /// <summary>
        /// Login to the application with user details
        /// </summary>
        /// <param name="userDetails">user details</param>
        /// <returns></returns>
        bool Login(object userDetails);

        /// <summary>
        /// Logout from the application with user details
        /// </summary>
        /// <param name="userDetails">user details</param>
        /// <returns></returns>
        bool LogOut(object userDetails);


    }
}
