namespace ClassDiagramm
{
    public class DepositAccounts : BankAccounts, IPercentIncrement
    {
        public DepositAccounts(string owner, double balance) : base(owner, balance)
        {
        }
    }
}