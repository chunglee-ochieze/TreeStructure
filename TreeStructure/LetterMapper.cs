using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public static class LetterMapper
    {
        public static string ConvertNumberToLetters(int index)
        {
            if (index == 0)
                return "A0";

            var letter = string.Empty;

            while (--index >= 0)
            {
                letter = (char)('A' + index % 26) + letter;
                index /= 26;
            }

            return letter;
        }
    }
}
