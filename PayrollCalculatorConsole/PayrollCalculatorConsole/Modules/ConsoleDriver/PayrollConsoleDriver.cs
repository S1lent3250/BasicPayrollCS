using System;
using PayrollCalculatorConsole.Modules.Meta;

namespace PayrollCalculatorConsole.Modules.Console
{
    public class PayrollConsoleDriver : Utils.Utils
    {
        // The payroll console driver like the one found in the GUI
        // WPF version of this console project. The only difference
        // is: you don't have a GUI and instead, you have a console
        // similar to the C++ payroll program. So, the prompts will
        // loop and repeat until the correct value is supplied.
        // So, all in all, just think of this object as the Payroll
        // namespace module from the C++ counterpart.
        private double pay, taxes, results;
        Boolean showEnteredValues;
        int hours;

        // Class driver init
        private MetaStrings mstr = new MetaStrings();

        // Default constructor - All values are set to 0.
        public PayrollConsoleDriver()
        {
            hours = 0;
            pay = 0.00;
            taxes = 0.00;
            showEnteredValues = false;
        }

        ///
        /// <summary>
        /// Just like in the C++ counterpart, the primary sub-driver function
        /// took a boolean true/false switch parameter that told the meta
        /// program to display the entered values or not. This can be done using
        /// the single overloaded constructor that takes a boolean true/false
        /// parameter to match the [1/0] parameter values that will be supplied
        /// to the main driver program.
        /// </summary>
        /// <param name="showEnteredValues">When this is set to true, the values
        ///                 that are entered into the prompts will be displayed
        ///                 beneath the initial prompt.</param>
        ///
        public PayrollConsoleDriver(Boolean showEnteredValues)
        {
            this.showEnteredValues = showEnteredValues;
        }
        // @Note: there will not be a setter for the one boolean switch...

        ///
        /// <summary>
        /// The main calculator sub-driver function. The main purpose of this
        /// function is to get the values, validate them, apply the information
        /// to the results double variable and then display the results to the
        /// user...like in the C++ counterpart.
        /// </summary>
        ///
        public void Calculate()
        {
            // Get user input for hours
            System.Console.Write("Enter total hours worked: ");
            hours = int.Parse(System.Console.ReadLine());
            
            //
            // While hours are below or equal to 0 or the hour integer
            // is below 3, then throw an error message string
            //
            while (hours <= 0 || hours < 3)
            {
                /* Print an error message */
                PrintError(false, mstr.ErrorEntryHours);

                System.Console.Write("Enter total hours worked: ");
                hours = int.Parse(System.Console.ReadLine());
            }
            // Display after validation = true
            if (showEnteredValues)
            {
                PrintYellowString("--> Integer value \"hours\" is " + hours);
            }
            // ********************************************************************

            // Get user input for pay-rate
            System.Console.Write("Enter your total pay-rate: $");
            pay = double.Parse(System.Console.ReadLine());

            while (pay <= 0 || pay < 7.50)
            {
                // Print an error
                PrintError(false, mstr.ErrorEntryPay);

                System.Console.Write("Enter your total pay-rate: $");
                pay = double.Parse(System.Console.ReadLine());
            }

            if (showEnteredValues)
            {
                PrintYellowString("--> Double value \"pay-rate\" is " + pay);
            }
            // ********************************************************************

            // Get user input for taxes
            System.Console.Write("Enter total tax deductibles: $");
            taxes = double.Parse(System.Console.ReadLine());

            while (taxes < 0)
            {
                PrintError(false, mstr.ErrorEntryTaxes);

                System.Console.Write("Enter your total pay-rate: $");
                pay = double.Parse(System.Console.ReadLine());
            }

            if (showEnteredValues)
            {
                PrintYellowString("--> Double value \"taxes\" is " + taxes);
            }
            // ********************************************************************

            // Calculate the total result using the information provided
            // by the user. If taxes == 0, then don't deduct the taxes
            if (taxes == 0)
            {
                results = hours * pay;
            } else
            {
                results = (hours * pay) - taxes;
            }

            // Print the resulting pay-roll
            PrintGreenString(
                "\n== Total Pay-Roll Results ============",
                "\t=> Total Hours worked .................... " + hours,
                "\t=> Total Pay-Rate ....................... $" + pay,
                "\t=> Total Tax-Deductibles ................ $" + taxes,
                "\t=> Total Pay-Roll ....................... $" + results,
                "\n"
                );
        }
    }
}
