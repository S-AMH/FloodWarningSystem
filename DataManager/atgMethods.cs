using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg
{
    static public class atgMethods
    {
        /// <summary>
        ///  Converts an integer to string with fixed digit count by adding zeros to left.
        /// </summary>
        /// <param name="_number">Number which should be converted to string with fixed digit count.</param>
        /// <param name="_digitsCount">Digit Counts for Corresponding integer.</param>
        /// <returns>String Corresponding to _number integer with _digitCount digits.</returns>
        /// <exception cref="System.ArgumentException">Thrown When <c>_number</c> digit counts is lower than <c>_digitsCount</c></exception>
        static public string xDigitNum(int _number, int _digitsCount)
        {
            if (_number.ToString().Length > _digitsCount)
                throw new ArgumentException("Error: Operation is not valid. digitCounts is lower than number's length.", "_digitCount");

            string result = "";
            for (int i = 0; i < _digitsCount - _number.ToString().Length; i++)
                result += "0";
            return result + _number.ToString();
        }
    }
}
