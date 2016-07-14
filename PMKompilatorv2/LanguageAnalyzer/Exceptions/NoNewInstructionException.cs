using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer.Exceptions
{
    public class NoNewInstructionException : ExceptionBase
    {
        public NoNewInstructionException() : base("Brak rozpoczęcia nowej instrukcji.")
        {

        }
    }
}
