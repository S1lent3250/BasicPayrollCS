using System;
using PayrollCalculatorConsole.Modules.Utils;

namespace PayrollCalculatorConsole.Modules.Utils
{
    public class Help : Utils
    {
        /*
         * This is the basic "help" module for this rather simple program.
         * There are two tiny modes for this module. Mode 1 is the plain and
         * simple "usage display" mode where the programs usage is displayed
         * and nothing more. Mode 2 is the full help mode that will display
         * the usage plus the help sequence.
         */
        private string usage;

        public Help()
        {
            usage = ".\\payroll.exe [1|0] | -h, --help";
        }

        /**
         * <summary>
         * Here, the user can set his or her usage string instead of using the
         * default string set in the modules default constructor. The usage is
         * typically the program_name followed by a recommended parameter, if
         * applicable, along with the classic "[OPTIONS]" charset and or the
         * helpful reminder to use the '-h' or '--help' switch to display the
         * full help module.
         * </summary>
         * <param name="usage">The programs usage.</param>
         */
        public Help(string usage)
        {
            this.usage = usage;
        }
        /**
         * <summary>
         * Just in case you have initialized this module in its primitive form, here
         * is a setter for the programs usage. The values supplied to this function
         * will override the value set in the default constructor, thus, the value set
         * within this function will be displayed as the set value.
         * </summary>
         * <param name="usage">The programs usage.</param>
         */
        public void SetUsage(string usage)
        {
            this.usage = usage;
        }
        /**
         * <summary>
         * This method returns the set usage string value that was set by the
         * user, either using the overloaded constructor or the setter function.
         * Basically, it returns the "usage" string and its set value.
         * </summary>
         */
        public string GetUsage()
        {
            return usage;
        }
        /**
         * <summary>
         * This will display the primary usage (in color).
         * </summary>
         */
        public void DisplayUsage()
        {
            PrintWhiteString(this.GetUsage());
            return;
        }
        /**
         * <summary>
         * This will return the full help for this program, this
         * includes the programs usage.
         * </summary>
         */
        public void DisplayFullHelp()
        {
            if (IsStringValid(usage))
            {
                PrintWhiteString(GetUsage());

                // Full help sub-node
                PrintYellowString(
                    "\nSwitch: 1\t\tDisplay the values entered into the prompts\n",
                    "Switch: 0:\t\tDo not display the vales entered into the prompts\n"
                    );
                return;
            } else { PrintError(true, "Invalid usage, try again..."); }
        }
    }
}
