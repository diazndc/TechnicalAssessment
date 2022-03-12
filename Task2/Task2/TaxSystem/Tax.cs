
namespace Task2
{
    internal class Tax
    {
        public string  Name { get; private set; }
        public float   TaxPercent { get; private set; }
        public float   Threshold { get; private set; }
        public float   MaxIncomeToConsider { get; private set; }

        public Tax(string name, float taxPercent, float threshold, float maxIncomeToConsider)
        {
            Name                = name;
            TaxPercent          = taxPercent;
            Threshold           = threshold;
            MaxIncomeToConsider = maxIncomeToConsider;
        }

        public TaxResultSet Apply(float beforeTax)
        {
            var taxable     = GetTaxableAmount(beforeTax);
            var deductable  = taxable * (TaxPercent / 100);
            var afterTax    = beforeTax - deductable;

            return new TaxResultSet(beforeTax,afterTax, this);
        }

        public float GetTaxableAmount(float n)
        {
            if (n <= Threshold)
                return 0;

            return MaxIncomeToConsider > 0 && n > MaxIncomeToConsider ? MaxIncomeToConsider - Threshold : n - Threshold;
        }
    }
}