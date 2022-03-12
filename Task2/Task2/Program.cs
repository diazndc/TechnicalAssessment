using System;

namespace Task2
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
           TaxSystem taxSystem = new TaxSystem();

            /**
             * Adding Taxes
             * Add more taxes using TaxSystem.AddTax()
             * taxSystem.AddTax(taxPercent, Threshold); OR  taxSystem.AddTax(taxPercent, Threshold, MaxIncomeToConsider)
             */
            //Income tax of 10% is incurred to the excess (amount above 1000).
            taxSystem.AddTax("Income Tax", 10, 1000);
            //Social contributions of 15% are expected to be made as well. As for the previous case, the taxable income is whatever is above 1000 IDR but social contributions never apply to amounts higher than 3000. 
            taxSystem.AddTax("Social Contributions Tax", 15, 1000, 3000);

            /**
             * Testing
             * Note that the method TaxSystem.ApplyTax(n) returns an object.
             * TaxSystem.ApplyTax(n).results.AfterTax can be used to see the after tax value only.
             */
            Console.WriteLine(taxSystem.ApplyTax(980));
            Console.WriteLine("\n\n");
            Console.WriteLine(taxSystem.ApplyTax(3400));

        }
    }
}
