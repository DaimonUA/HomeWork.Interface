namespace ClassDiagramm
{
    public interface IPercentIncrement
    {
        double InterestAccrual { get; set; }

        void SetInterestAccrual();
        void IncreaseBalance();
    }
}