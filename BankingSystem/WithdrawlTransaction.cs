using System.Transactions;

namespace BankExcercise
{
    internal class WithdrawlTransaction : Transaction
    {
        private decimal withdrawlAmount;

        public WithdrawlTransaction(decimal withdrawlAmount)
        {
            this.withdrawlAmount = withdrawlAmount;
        }
    }
}