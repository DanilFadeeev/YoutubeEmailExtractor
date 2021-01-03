using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace ApiWrapper.Utils
{
    /// <summary>
    /// provide useful extentions to simplify creating uris
    /// </summary>
    public static class UriBuilderExtenstions
    {

        /// <summary>
        /// add youtube api key from environment variable to query params on concrete uri builder
        /// </summary>
        /// <param name="builder">builder what query need key parametr</param>
        /// <returns>same builder with added key in query</returns>
        public static UriBuilder AddKey(this UriBuilder builder)
        {
            builder.AddQueryParam("key", Environment.GetEnvironmentVariable("YouTubeApiKey"));
            return builder;
        }
        /// <summary>
        /// Add new parametr to Uri query
        /// </summary>
        /// <remarks>method does not delete white space from begin and end of arguments</remarks>
        /// <param name="builder">Your builder</param>
        /// <param name="paramName">Parametr name</param>
        /// <param name="value">Parametr value. ADDQueryParam call ToString() of this parametr</param>
        /// <returns>Same UriBuilder with changed query</returns>
        /// <exception cref="ArgumentException">throws if any parametr is null or empty
        /// </exception>
        public static UriBuilder AddQueryParam(this UriBuilder builder, string paramName, object value)
        {
            if (IsNullOrEmpty(paramName))
                throw new ArgumentException("Param name must be set");

            if (value is null || IsNullOrEmpty(value.ToString()))
                throw new ArgumentException("value must be set");

            paramName = toUrlNormalString(paramName);
            string paramValue = toUrlNormalString(value.ToString());
            if (!IsNullOrEmpty(builder.Query))
                builder.Query = $"{builder.Query.Substring(1)}&{paramName}={paramValue}";
            else
                builder.Query = paramName + "=" + paramValue;

            return builder;
        }
        /// <summary>
        /// delete all query params in UriBuilder
        /// </summary>
        /// <param name="builder">builder whose query must be cleared</param>
        /// <returns>same builder with empty query</returns>
        public static UriBuilder ClearQuery(this UriBuilder builder)
        {
            builder.Query = Empty;
            return builder;
        }
        /// <summary>
        /// change all white space in string to url equivalent
        /// </summary>
        /// <param name="input">string to modify</param>
        /// <returns>url adapted string</returns>
        private static string toUrlNormalString(string input)
        {
            if (IsNullOrEmpty(input))
                throw new ArgumentException("value must be set");

            return input.Replace(" ", "%20")
                .Replace("\t", "%20")
                .Replace("\n", "%20");
        }
    }
}
