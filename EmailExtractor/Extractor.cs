using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailExtractor
{
    class Extractor
    {
        /// <summary>
        /// using to find emails in message by certain regulars
        /// </summary>
        List<Regex> Regexes = new RegexProvider().GetRegexes();
        /// <summary>
        /// search all unique emails in message
        /// </summary>
        /// <param name="message">text with (without) emails to extract</param>
        /// <returns>List of emails <para> 
        /// Empty list if message not contains any emails</para></returns>
        public List<string> GetEmailsFromMessage(string message)
        {
            List<string> result = new();
            if (message is null)
                return result;



            return result;
        }
    }
}
