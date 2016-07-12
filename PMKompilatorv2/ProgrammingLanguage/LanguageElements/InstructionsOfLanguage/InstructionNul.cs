using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.ProgrammingLanguage.LanguageElements.InstructionsOfLanguage
{
    public class InstructionNul : IInstructions
    {
        public string Text
        {
            get
            {
                return "nul";
            }
        }

        public int Verify()
        {
            return -1;
        }
    }
}
