using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Verify()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolAVariable() == true)
            {
                Analyzer.AddInitializedVariable();
                return -1;
            }
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true) return 0;
            return 4;
        }
    }
}
