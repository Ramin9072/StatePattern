using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Class
{
    public class LoanRequest
    {
        public LoanRequestState State { get; set; }
        public long Amount { get; private set; }
        public TimeSpan LoanDuration { get; private set; }
        public LoanRequest()
        {
            this.State = new DraftState();
        }
        public void Update(long amount, TimeSpan duration)
        {
            if (State.CanUpdateProgress())
            {
                Amount = amount;
                LoanDuration = duration;
            }
            else
            {
                throw new Exception("!!");
            }
        }

        public void Accept()
        {
            if (this.State.CanAccepted())
            {
                State = new AcceptedState();
            }
            //if (State == LoanRequestState.InProgress)
            //{
            //    State = LoanRequestState.Accepted;
            //}
            //else
            //{
            //    throw new Exception("!!!");
            //}
        }
    }
    //LoanRequestState() پیدا سازی جدید
    //public enum LoanRequestState
    //{
    //    Draft,
    //    InProgress,
    //    Rejected,
    //     
    //}
}
