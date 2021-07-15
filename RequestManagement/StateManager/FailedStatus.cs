using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateManager
{
    public class FailedStatus : IStateManagement
    {
        public void ApprovedState()
        {
            throw new NotImplementedException();
        }

        public void CancelState()
        {
            throw new NotImplementedException();
        }

        public void EnterState()
        {
            throw new NotImplementedException();
        }

        public void ProcessState()
        {
            throw new NotImplementedException();
        }
    }
}
