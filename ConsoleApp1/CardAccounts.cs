namespace ClassDiagramm
{
    public class CardAccounts : BankAccounts, IPercentIncrement, IDebitCredit
    {
        public CardAccounts(string owner, double balance) : base(owner, balance)
        {
        }

        public void CreditBalance()
        {
            throw new System.NotImplementedException();
        }

        public void DebitBalace()
        {
            throw new System.NotImplementedException();
        }
    }
}