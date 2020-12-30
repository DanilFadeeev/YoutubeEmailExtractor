﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace YouTubeApiWrapper.Utils
{
    /// <summary>
    /// provide useful extentions to simplify creating uris
    /// </summary>
    public static class UriBuilderExtenstions
    {
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

            if (builder.Query != null && builder.Query.Length > 1)
                builder.Query = $" {builder.Query.Substring(1)}&{paramName}={paramValue}";
            else
                builder.Query = paramName + paramValue;

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
