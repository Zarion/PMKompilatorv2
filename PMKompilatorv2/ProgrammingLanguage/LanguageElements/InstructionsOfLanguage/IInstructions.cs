using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.InstructionsOfLanguage
{
    public interface IInstructions
    {
        string Text
        {
            get;
        }

        int Verify();
    }
}
