using System;
namespace PayrollCalculatorConsole.Modules.Console
{
    public class BasicValidator
    {
        // The 'Basic Validator' module. This modules purpose is
        // to provide basic validation for values such as strings
        // integers, doubles, and objects.
        private int integer;
        private double doubleValue;
        private string strValue;

        // Default constructor - All integer related values are set to 0
        public BasicValidator()
        {
            integer = 0;
            doubleValue = 0;
            strValue = null;
        }

        ///
        /// <summary>
        /// Set a string for validation...
        /// </summary>
        /// <param name="strValue">A string value to validate.</param>
        ///
        public BasicValidator(string strValue)
        {
            this.strValue = strValue;
        }

    }
}
