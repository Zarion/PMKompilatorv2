using PMKompilatorv2.LanguageAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.InstructionsOfLanguage
{
    public class InstructionIf : IInstructions
    {
        public string Text
        {
            get
            {
                return "if";
            }
        }

        public void Verify()
        {
            Language.Expressions.Verify();
            Language.Instructions.VerifyInstruction();
            Language.Instructions.VerifyInstruction();
        }

    }
}
