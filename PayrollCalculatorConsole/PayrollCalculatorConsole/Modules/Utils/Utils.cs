using System;
using System.Collections;

/**
 * <summary>
 * Basic utilities for the program like the ones that are
 * found in the C++ version of this program. The utilities
 * module contains basic string validation, simplified
 * string printing methods, and colored string printing
 * functions that allow the user to print multiple strings
 * of a different color.
 * </summary>
 */
namespace PayrollCalculatorConsole.Modules.Utils
{
    public class Utils
    {
        /* Basic string validator */
        public bool IsStringValid(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == null)
                    return false;
                if (strings[i].Length == 0)
                    return false;
            }
            // Return true if all conditions are met
            return true;
        }

        /* A simple function that substitutes the Console.WriteLine() sequence */
        public void Echo(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (IsStringValid(strings[i]))
                {
                    System.Console.WriteLine(strings[i]);
                } else { return; }
            }
        }

        /* Prints a string or a set of strings in the color green */
        public void PrintGreenString(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (IsStringValid(strings[i]))
                {
                    System.Console.ForegroundColor = ConsoleColor.Green;
                    Echo(strings[i]);
                    Reset();
                } else { return; }
            }
        }

        /* This one prints out a string or strings in the color red */
        public void PrintRedString(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (IsStringValid(strings[i]))
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    Echo(strings[i]);
                    Reset();
                } else { return; }
            }
        }

        /* This one prints out string(s) using the color yellow */
        public void PrintYellowString(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (IsStringValid(strings[i]))
                {
                    System.Console.ForegroundColor = ConsoleColor.Yellow;
                    Echo(strings[i]);
                    Reset();
                }
                else { return; }
            }
        }

        /* And finally, this one prints out a string or strings using the color white */
        public void PrintWhiteString(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (IsStringValid(strings[i]))
                {
                    System.Console.ForegroundColor = ConsoleColor.White;
                    Echo(strings[i]);
                    Reset();
                }
                else { return; }
            }
        }

        /* Prints out an error string */
        public void PrintError(bool exit_on_error, params string[] errors)
        {
            for (int i = 0; i < errors.Length; i++)
            {
                if (IsStringValid(errors[i]))
                {
                    // If exit_on_error is true; then: system.exit(1)
                    // Else: pass;
                    if (exit_on_error)
                    {
                        PrintRedString(errors[i]);
                        Environment.Exit(1);
                    } else
                    {
                        PrintRedString(errors[i]);
                    }
                    // Return this error message
                } else { this.PrintError(true, "Invalid ERROR string, please try again..."); }
            }
        }

        /* Special */
        private static void Reset()
        {
            System.Console.ResetColor();
        }
    }
}
