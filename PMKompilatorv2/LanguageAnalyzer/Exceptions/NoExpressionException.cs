using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer.Exceptions
{
    public class NoExpressionException : ExceptionBase
    {
        public NoExpressionException() : base("Brak wyrażenia.")
        {

        }
    }
}
