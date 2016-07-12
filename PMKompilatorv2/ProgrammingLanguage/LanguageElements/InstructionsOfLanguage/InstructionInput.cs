using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMKompilatorv2.LanguageAnalyzer;

namespace PMKompilatorv2.LanguageElements.InstructionsOfLanguage
{
    public class InstructionInput : IInstructions
    {
        public string Text
        {
            get
            {
                return "input";
            }
        }

        public void Verify()
        {
            Language.Variable.Verify();    
        }
    }
}
