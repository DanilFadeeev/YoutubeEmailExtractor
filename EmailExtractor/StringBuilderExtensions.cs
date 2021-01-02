using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Char;
namespace EmailExtractor
{
    /// <summary>
    /// provides extensions for String builder
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Check if symbol is special, if so replace it to space.
        /// This method support quote. Symbols between " " does not change
        /// </summary>
        /// <param name="sb">your builder with chars to modify</param>
        /// <param name="ignoreQuote">set true if you dont want check quotes. Set true if you want change " symbol to space too</param>
        /// <param name="exclude">contains symbols what must not be changed</param>
        /// <returns>same builder with changed special symbols</returns>
        public static StringBuilder ReplaceSpecialBySpace(this StringBuilder sb,
                bool ignoreQuote = false,  params char[] exclude)
        {
            if (sb.Length is 0)
                return sb;

            //symbol index
            int i = 0;
            int j = ignoreQuote ? 0 : sb.Length - 1;
            //skip start quote
            if (sb[0] is '\"' && !ignoreQuote)
            {
                while (sb[j] is not '\"')
                    j--;
                i = j + 1;
            }
            //may be only one quote and only on begin of email address
            ignoreQuote = true;

            //replace symbols
            while (i < sb.Length)
            {
                if (!(IsLetterOrDigit(sb[i]) || IsWhiteSpace(sb[i]) || exclude.Contains(sb[i])))
                    sb[i] = ' ';
                i++;
            }

            return sb;
        }
        /// <summary>
        /// Check if symbol is special, if so replace it to space.
        /// This method support quote. Symbols between " " does not change
        /// </summary>
        /// <param name="sb">your builder with chars to modify</param>
        /// <param name="ignoreQuote">set true if you dont want check quotes. Set true if you want change " symbol to space too</param>
        /// <param name="exclude">contains symbols what must not be changed</param>
        /// <returns>same builder with changed special symbols</returns>
        public static StringBuilder ReplaceSpecialBySpace(this StringBuilder sb, string exclude, bool ignoreQuote = false) =>
            sb.ReplaceSpecialBySpace(ignoreQuote, exclude.ToCharArray());

        /// <summary>
        /// Delete all duplicated At's (@) symbols from builder
        /// </summary>
        /// <param name="sb">builder where duplicate characters will remove</param>
        /// <returns>same bulder with removed duplicates</returns>
        public static StringBuilder ReplaceWhiteSpaceAroundAt(this StringBuilder sb)
        {
            //index of symbol
            int i;
            //position to searc @ in IndexOfEt method
            int searchPosition = 0;
            foreach (int j in IndexesOfAt())
            {
                //show symbol on the right of @
                i = j + 1;
                //delete all symbols on the right
                while (i < sb.Length && IsWhiteSpace(sb[i]))
                    sb.Remove(i, 1);
                //show symbols on the left of @
                i = j - 1;
                //delete symbols and change search position
                while (i >= 0 && IsWhiteSpace(sb[i]))
                {
                    sb.Remove(i, 1);
                    i--;
                    searchPosition--;
                }
            }
            return sb;

            //search indexes of all @ and return it
            IEnumerable<int> IndexesOfAt()
            {

                for (searchPosition = 0; searchPosition < sb.Length; searchPosition++)
                    if (sb[searchPosition] == '@')
                        yield return searchPosition;
            }
        }
        /// <summary>
        /// replace al duplicate multipy @ to one @ <example>asdf@@@@@.com change to asdf@.com</example>
        /// </summary>
        /// <param name="sb">stringbuidler with chars to modify</param>
        /// <returns></returns>
        public static StringBuilder RemoveDuplicateAt(this StringBuilder sb)
        {
            for (int i = 0; i < sb.Length - 1;)
                if (sb[i] == sb[i + 1] && sb[i + 1] == '@')
                    sb.Remove(i + 1, 1);
                else i++;

            return sb;
        }
    }
}
