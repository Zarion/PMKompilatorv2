using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer.Exceptions
{
    public class NoVariableException : ExceptionBase
    {
        public NoVariableException() : base("Po instrukcji oczekiwana jest zmienna.")
        {

        }
    }
}
