using PMKompilatorv2.LanguageAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.InstructionsOfLanguage
{
    public class InstructionWhile : IInstructions
    {
        public string Text
        {
            get
            {
                return "while";
            }
        }

        public void Verify()
        {
            Language.Expressions.Verify();
            Language.Instructions.VerifyInstruction();
        }
    }
}
