using System.Collections;

namespace Task2
{
    class TaxSystem
    {
        private ArrayList taxes = new ArrayList();

        public TaxSystemResultSet ApplyTax(float beforeTaxes)
        {
            var rs          = new TaxSystemResultSet();
            var deductions  = 0f;

            foreach(Tax tax in taxes)
            {
                TaxResultSet taxResult = tax.Apply(beforeTaxes);

                if (taxResult.wasTaxed())
                {
                    rs.IndividualTaxResults.Add(taxResult);
                    deductions += taxResult.GetDeductedAmount();
                }
                
            }

            rs.results.BeforeTaxes = beforeTaxes;
            rs.results.AfterTaxes  = beforeTaxes - deductions;

            return rs;
        }

        public void AddTax(string name, float taxPercent, float threshold)
        {
            AddTax(name, taxPercent, threshold, -1);
        }

        public void AddTax(string name, float taxPercent, float threshold, float maxIncomeToConsider)
        {
            taxes.Add(new Tax(name, taxPercent, threshold, maxIncomeToConsider));
        }

    }
}