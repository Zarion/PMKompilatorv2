using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer.Exceptions
{
    public class NoNextSymbolException : ExceptionBase
    {
        public NoNextSymbolException() : base("Nieoczekiwane zakończenie programu.")
        {

        }
    }
}
