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
        public override bool CanAccepted() => true;
        public override bool CanUpdateProgress() => true;
    }
    public class AcceptedState : LoanRequestState
    {
        public override bool CanAccepted() => true;
        public override bool CanUpdateProgress() => true;
    }

    public class RejectedState : LoanRequestState
    {
    }
   
}
