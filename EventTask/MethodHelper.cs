using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MethodHelper
    {
        public static string Space(string str)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (i > 0 && i < str.Length)
                    sb.Append('_');
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public static string Reverse(string str)
        {
            var sb = new StringBuilder(str);

            for (int i = 0, length = str.Length / 2; i < length; i++)
            {
                var secondIndex = str.Length - 1 - i;
                var tmp = sb[i];

                sb[i] = sb[secondIndex];
                sb[secondIndex] = tmp;
            }

            return sb.ToString();
        }
    }
}
