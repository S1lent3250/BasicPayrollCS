using System;
using System.Collections;
using PayrollCalculatorConsole.Modules.Meta;
using PayrollCalculatorConsole.Modules.Utils;
using PayrollCalculatorConsole.Modules.Console;

namespace PayrollCalculatorConsole
{
    class MainClass
    {
        // Class objects
        private static Utils utils = new Utils();
        private static MetaStrings mstr = new MetaStrings();
        private static Help help = new Help(".\\payroll.exe [1|0] | -h, --help");

        // Init console sub-driver
        private static PayrollConsoleDriver console;

        public static void Main(string[] args)
        {
            /*
             * Like the C++ version of this program, this program will take
             * only one sys.argv argument switch. The two switches are either
             * [1] or [0] (Binary) or [true]/[false] (boolean). The user must
             * supply either one in order for the program to run properly. Begin
             * by checking if the user has the sufficient argument count
             */
            try
            {
                // Check the argument length to determine whether or not the
                // program proceeds
                if (args.Length is 0)
                {
                    foreach (string str in args)
                    {
                        if (str.StartsWith("\\", StringComparison.Ordinal) || str.EndsWith("//", StringComparison.Ordinal))
                        {
                            utils.PrintError(true, mstr.ErrorINVArg + args[0].ToString());
                        }
                        else if (str.StartsWith("/", StringComparison.Ordinal))
                        {
                            // Do something else...
                            return; // Nothing...
                        }
                    }
                } else
                {
                    // If everything checks out good, then proceed to act upon the parameter
                    // supplied to this program by the user.
                    if (args[0].Contains("1") || args[0].Contains("true"))
                    {
                        // Run the payroll program displaying the entered prompt values
                        console = new PayrollConsoleDriver(true);
                        console.Calculate();
                    }

                    if (args[0].Contains("0") || args[0].Contains("false"))
                    {
                        // Run the payroll program without displaying the entered prompt values
                        console = new PayrollConsoleDriver(false);
                        console.Calculate();
                    }

                    if (args[0].Contains("-h") || args[0].Contains("--help"))
                    {
                        // Display the help message and exit
                        help.DisplayFullHelp();
                        return;
                    }
                }

            } catch (Exception e)
            {
                help.DisplayFullHelp();
                return;
            }
        }
    }
}
