using PMKompilatorv2.LanguageAnalyzer;
using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.Instructions
{
    public class InstructionLet : IInstructions
    {
        public string Text
        {
            get
            {
                return "let";
            }
        }

        public void Verify()
        {
            Language.Variable.Verify();
            Language.Expressions.Verify();
        }
    }
}
