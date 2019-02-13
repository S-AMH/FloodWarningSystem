using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    class atgFunctions
    {
        public string xDigitNum(int _number, int _digitsCount)
        {
            if (_number.ToString().Length < _digitsCount)
                throw new ArgumentException("Error: Operation is not valid. digitCounts is lower than number \'s length.", "_digitCount");

            string result = "";
            for (int i = 0; i < _number.ToString().Length - _digitsCount; i++)
                result += "0";
            return result + _number.ToString();
        }
    }
}
