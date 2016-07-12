using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.ExpressionsOfLanguage.OneArgumentExpressions
{
    public class OneArgumentBaseExpression : IExpression
    {
        virtual public string Text
        {
            get
            {
                return "";
            }
        }

        public int Verify()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolAVariable() == true)
            {
                if (Analyzer.CheckIfVariableIsInitialized()) return -1;
                return 5;
            }
            if (Analyzer.ReadCode.IsSymbolANumber() == true) return -1;
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true) return 0;
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == false) return 4;
            if (Analyzer.ReadCode.IsSymbolAnOneArgumentExpresion() == true ) return Language.Expressions.OneArgumentExpresion.Verify();
            if (Analyzer.ReadCode.IsSymbolAnTwoArgumentExpresion() == true ) return Language.Expressions.TwoArgumentExpresion.Verify();
            return 2;
        }
    }
}
