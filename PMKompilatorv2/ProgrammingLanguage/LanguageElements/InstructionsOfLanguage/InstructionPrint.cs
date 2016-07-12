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

        public int Verify()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolAVariable() == true)
            {
                if(Analyzer.CheckIfVariableIsInitialized()) return -1;
                return 5;
            }
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true) return 0;
            return 4;
        }
    }
}
