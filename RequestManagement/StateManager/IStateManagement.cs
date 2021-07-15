using System;

namespace StateManager
{
    public interface IStateManagement
    {
        void EnterState();
        void ProcessState();
        void CancelState();
        void ApprovedState();


    }
}
