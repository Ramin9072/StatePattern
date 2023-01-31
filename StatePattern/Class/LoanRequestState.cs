using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Class
{
    public abstract class LoanRequestState
    {
        public virtual bool CanUpdateProgress() => false;
        public virtual bool CanAccepted() => false;
    }
    public class DraftState : LoanRequestState
    {
        public override bool CanUpdateProgress() => true;

    }
    public class InProgressState : LoanRequestState
    {
        public override bool CanUpdateProgress() => true;
    }
    public class RejectedState : LoanRequestState
    {
        public virtual bool CanAccepted() => true; 

    }
    public class AcceptedState : LoanRequestState
    {
        public virtual bool CanAccepted() => true;
    }
}
