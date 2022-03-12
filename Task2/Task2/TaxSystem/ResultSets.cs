using System.Collections;

namespace Task2
{
    internal class TaxSystemResultSet
    {

        public TaxResultSet results               = new TaxResultSet();
        public ArrayList    IndividualTaxResults  = new ArrayList();


        override public string ToString()
        {
            var str  = "Taxes for "+results.BeforeTaxes+" gross income\n";
            str += "    Applied Taxes(" + IndividualTaxResults.Count + ")\n";

            foreach (TaxResultSet trs in IndividualTaxResults)
            {
                str += "       -" + trs;
            }

            str += "    Before Tax: " + results.BeforeTaxes + "\n";
            str += "    After Tax: "  + results.AfterTaxes  + "\n";
            return str;
        }

    }

    internal class TaxResultSet
    {
        public float BeforeTaxes;
        public float AfterTaxes;
        public Tax   UsedTax;

        public TaxResultSet()
        {
        }

        public TaxResultSet(float beforeTaxes, float afterTaxes, Tax usedTax)
        {
            BeforeTaxes = beforeTaxes;
            AfterTaxes  = afterTaxes;
            UsedTax     = usedTax;
        }


        public float GetDeductedAmount()
        {
            return BeforeTaxes - AfterTaxes;
        }

        public float GetTaxableAmount()
        {
            return UsedTax.GetTaxableAmount(BeforeTaxes);
        }

        internal bool wasTaxed()
        {
            return BeforeTaxes != AfterTaxes;
        }

        public override string ToString()
        {
            var str = UsedTax.Name + " was applied for gross income: " + BeforeTaxes + " IDR. ";
            str += "Deduction of " + UsedTax.TaxPercent + "% out of " + GetTaxableAmount() + " IDR ";
            str += "taxable amount was " + GetDeductedAmount() + " IDR \n";
            return str;
        }
    }
}