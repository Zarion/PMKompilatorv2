using PMKompilatorv2.LanguageAnalyzer;
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

        public void Verify()
        {
            /*Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolAVariable() == true && Analyzer.CheckIfVariableIsInitialized())
                throw Analyzer.CompilationExceptions.NotInitializedVariableException;
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true) throw Analyzer.CompilationExceptions.NoNextSymbolException; //Brak kolejnego symbolu
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == false) throw Analyzer.CompilationExceptions.UnknownSymbolException; //Symbol nie należący do języka
            if (Analyzer.ReadCode.IsSymbolAnOneArgumentExpresion() == true ) Language.Expressions.OneArgumentExpresion.Verify();
            if (Analyzer.ReadCode.IsSymbolAnTwoArgumentExpresion() == true ) Language.Expressions.TwoArgumentExpresion.Verify();
            if (!Analyzer.ReadCode.IsSymbolANumber()) throw Analyzer.CompilationExceptions.IncorrectExpressionException;*/
            Language.Expressions.Verify();
        }
    }
}
