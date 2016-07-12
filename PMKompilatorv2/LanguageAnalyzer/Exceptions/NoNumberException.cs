using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer.Exceptions
{
    public class NoNumberException : ExceptionBase
    {
        public NoNumberException() : base("Oczekiwany znak nie jest liczbą.")
        {

        }
    }
}
