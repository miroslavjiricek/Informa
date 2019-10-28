

using InformaTest.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InformaTest.Services
{
    /// <summary>
    /// class implementing validation and autofilling functions
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// method for autofilling date to search by
        /// </summary>
        /// <param name="date">current date (complete or incomplete)</param>
        /// <returns></returns>
        public static string AutoFillDate(string date)
        {
            //seting up default date to search for
            var defaultDate = "1900/01/01";
            if(date.StartsWith("2"))
            {
                defaultDate = "2000/01/01";
            }
            date = date.Replace('-', '/');
            date = date.Replace('.', '/');
            date = date.Replace('\\', '/');
            //enriching the uncomplete date with the default one
            defaultDate = defaultDate.Remove(0, date.Length);
            return string.Concat(date, defaultDate);
        }

        /// <summary>
        /// method for extracting <,>,= from input
        /// </summary>
        /// <param name="value">input value</param>
        /// <returns></returns>
        public static string ExtractDataOperator(string value)
        {
            var dateOperator = "";
            foreach (var match in Regex.Matches(value, CONST.DATE_OPERATORS))
            {
                dateOperator += match;
            }
            return dateOperator;
        }
    }
}
