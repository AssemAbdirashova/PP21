using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attempt2                                                         
{
    class Rules
    {
        public static bool IsDouble(char c)
        {
            char[] arr = new char[] { '.' };
            return arr.Contains(c);
        }
        public static bool IsAgain(char c)
        {
            char[] arr = new char[] { 'C' };
            return arr.Contains(c);
        }

        public static bool IsDigit(char c) 
        {
            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return arr.Contains(c);
        }
        public static bool IsNotZeroDigit(char c)
        {
            char[] arr = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return arr.Contains(c);
        }
        public static bool IsZero(char c)
        {
            char[] arr = new char[] { '0' };
            return arr.Contains(c);
        }
        public static bool IsOption(char c)
        {
            char[] arr = new char[] { '-', '+' ,'*','/'};
            return arr.Contains(c);
        }
        public static bool IsEqual(char c)
        {
            char[] arr = new char[] { '=' };
            return arr.Contains(c);
        }
        }
}
