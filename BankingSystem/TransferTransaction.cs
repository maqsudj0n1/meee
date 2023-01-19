namespace BankExcercise
{
    internal class TransferTransaction
    {
        private decimal transferAmount;
        private int transferToId;
        private int owner;

        public TransferTransaction(decimal transferAmount, int transferToId, int owner)
        {
            this.transferAmount = transferAmount;
            this.transferToId = transferToId;
            this.owner = owner;
        }
    }
}