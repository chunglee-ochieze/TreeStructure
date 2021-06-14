using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public static class LetterMapper
    {
        public static string ConvertNumberToLetters(long index)
        {
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
