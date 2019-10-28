using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaTest.Resource
{
    /// <summary>
    /// Class of Constants
    /// </summary>
    public static class CONST
    {
       //-------REGEXs and SEARCHING
       public const string DATE_OPERATORS = @"[<>=]";
       public const string DIGIT = @"\d+";
       //-------MESSAGES
       public const string INVALID_DATE = @"Invalid date form. Please try different date format (yyyy/mm/dd)";
    }
}
