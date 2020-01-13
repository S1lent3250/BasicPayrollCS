using System;

namespace PayrollCalculatorConsole.Modules.Meta
{
    public class MetaStrings
    {
        /* Prompt strings. */
        public string PromptHours = "Enter total hours worked: ";
        public string PromptPayRate = "Enter your Pay-Rate: $";
        public string PromptTaxes = "Enter total tax deductibles: $";

        /* Error message strings. */
        public string ErrorEntryHours = "You've supplied an invalid amount of hours. (Cannot be less then 0 or 3)...";
        public string ErrorEntryPay = "Invalid pay-rate entry. (Cannot be below 0 or 7.50 [Minimum Wage])...";
        public string ErrorEntryTaxes = "Taxes cannot be anything below 0, try again...";
        public string ErrorINVArg = "Invalid argument detected -> ";
    }
}
