using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.String;
using static System.Char;
using System.Linq;

namespace EmailExtractor
{
    public class Extractor
    {
        /// <summary>
        /// using to find emails in message by certain regulars
        /// </summary>
        public List<Regex> Regexes { get; set; } = new RegexProvider().GetFindRegexes();
        public Regex CheckRegex { get; set; } = new RegexProvider().CheckEmailRegex;
        /// <summary>
        /// search all unique emails in message
        /// </summary>
        /// <param name="message">text with (without) emails to extract</param>
        /// <returns>List of emails <para> 
        /// Empty list if message not contains any emails</para></returns>
        public List<string> GetEmailsFromMessage(string message)
        {
            List<string> result = new();
            if (IsNullOrWhiteSpace(message))
                return new();

            message = PrepareToExtract(message);

            //collect all emails finded by regexes
            List<string> potentialEmails = new();
            foreach (var r in Regexes)
                foreach (var m in r.Matches(message) as IEnumerable<Match>)
                    potentialEmails.Add(m.Value);
            foreach (var s in potentialEmails)
                result.Add(s);
            //remove emails in incorrect format
            foreach (var e in potentialEmails)
                if (!CheckRegex.IsMatch(e))
                    result.Remove(e);

            return result.Distinct().ToList();
        }

        string PrepareToExtract(string message) =>
            new StringBuilder(message)
             .ReplaceSpecialBySpace(exclude: "!#$%&'*+-/=?^_`@.{|}~")
             .ReplaceWhiteSpaceAroundAt()
            .RemoveDuplicateAt()
             .ToString();
    }
}
