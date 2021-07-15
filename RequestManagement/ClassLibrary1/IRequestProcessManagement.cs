using System;

namespace RequestHandler
{
    public interface IRequestProcessManagement
    {
        /// <summary>
        /// To add request to the qeueue to process
        /// </summary>
        /// <param name="requestDetails">request details</param>
        /// <returns>returns true once added to the qeueue</returns>
        bool AddRequest(object requestDetails);

        /// <summary>
        /// Update the request details to the qeueue
        /// </summary>
        /// <param name="requestDetails">request details</param>
        /// <returns>returns true once updated request in the qeueue</returns>
        bool UpdateRequest(object requestDetails);

        /// <summary>
        /// Cancel request from the Queueu
        /// </summary>
        /// <param name="requestDetails">request details</param>
        /// <returns>returns true once cancel from the qeueue</returns>
        bool CancelRequest(object requestDetails);

        /// <summary>
        /// Get the status of the request placed
        /// </summary>
        /// <param name="RequestId">request details</param>
        /// <returns>returns object with status of the request</returns>
        object GetRequestStatus(object requestId);

        
    }
}
