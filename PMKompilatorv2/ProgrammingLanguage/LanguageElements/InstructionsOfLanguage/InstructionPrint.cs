using PMKompilatorv2.LanguageAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.InstructionsOfLanguage
{
    public class InstructionPrint : IInstructions
    {
        public string Text
        {
            get
            {
                return "print";
            }
        }

        public void Verify()
        {
            Language.Variable.Verify();
            Language.Variable.VerifyIfVariableIsInitialized();
        }
    }
}
