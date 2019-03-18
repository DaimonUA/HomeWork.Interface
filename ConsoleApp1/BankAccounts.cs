namespace ClassDiagramm
{
    public class BankAccounts : IPercentIncrement
    {
        private double balance;
        private string owner;

        public BankAccounts(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public double Balance
        {
            get;
        }

        public string Owner
        {
            get;
        }
        public double InterestAccrual { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void GetBalance()
        {
            throw new System.NotImplementedException();
        }

        public void GetOwner()
        {
            throw new System.NotImplementedException();
        }

        public void CloseAccount()
        {
            throw new System.NotImplementedException();
        }

        public void SetInterestAccrual()
        {
            throw new System.NotImplementedException();
        }

        public void IncreaseBalance()
        {
            throw new System.NotImplementedException();
        }
    }
}