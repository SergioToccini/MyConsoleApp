using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace RomeTask
{
    public class Converter
    {
        /// <summary>
        /// Сложность вычисления O(n)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Convert(string value)
        {
            var result = 0;
            var chars = value.ToCharArray();

            for (var i = 0; i < chars.Length; i++)
            {
                var currentArabicDigit = ToArabicDigit(chars[i]);

                if (i < chars.Length - 1 && currentArabicDigit < ToArabicDigit(chars[i + 1]))
                {
                    result -= currentArabicDigit;
                }
                else
                {
                    result += currentArabicDigit;
                }
            }

            return result;
        }

        /// <summary>
        /// I - 1
        /// V - 5
        /// X - 10
        /// L - 50
        /// C - 100
        /// D - 500
        /// M - 1000
        /// </summary>
        private readonly char[] _correctChars = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};

        private int ToArabicDigit(char romeDigit)
        {
            if (!IsValid(romeDigit))
                throw new ArgumentException($"Rome char is incorrect! ({romeDigit})");

            return romeDigit switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Validation
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        private bool IsValid(char ch)
        {
            return _correctChars.Contains(ch);
        }

    }
}
