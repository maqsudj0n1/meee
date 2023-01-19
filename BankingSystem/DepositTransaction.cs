using System.Transactions;

namespace BankExcercise
{
    internal class DepositTransaction : Transaction
    {
        private decimal amount;

        public DepositTransaction(decimal amount)
        {
            this.amount = amount;
        }
    }
}