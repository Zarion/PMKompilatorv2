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

        public int Verify()
        {
            int response = 7;
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true) return 0;
            if (Analyzer.ReadCode.IsSymbolAnOneArgumentExpresion() == true) response = Language.Expressions.OneArgumentExpresion.Verify();
            if (Analyzer.ReadCode.IsSymbolAnTwoArgumentExpresion() == true) response = Language.Expressions.TwoArgumentExpresion.Verify();
            if (response == -1) response = Language.Instructions.VerifyInstruction();
            return response;
        }
    }
}
