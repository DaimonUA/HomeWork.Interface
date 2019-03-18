namespace ClassDiagramm
{
    public class CurrentAccounts : BankAccounts, IDebitCredit
    {
        public CurrentAccounts(string owner, double balance) : base(owner, balance)
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