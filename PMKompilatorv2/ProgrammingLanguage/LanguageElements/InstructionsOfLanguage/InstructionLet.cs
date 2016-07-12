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

        public int Verify()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolAVariable() == false) return 1;
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true) return 0;
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == false) return 4;
            Analyzer.AddInitializedVariable();

            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolAnOneArgumentExpresion() == true) return Language.Expressions.OneArgumentExpresion.Verify();
            if (Analyzer.ReadCode.IsSymbolAnTwoArgumentExpresion() == true) return Language.Expressions.TwoArgumentExpresion.Verify();
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true) return 0;
            return 4;
        }
    }
}
