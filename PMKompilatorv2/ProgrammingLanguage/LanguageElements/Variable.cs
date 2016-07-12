using PMKompilatorv2.LanguageAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.ProgrammingLanguage.LanguageElements
{
    public class Variable
    {
        public string Text
        {
            get
            {
                return "^[a-z]$";
            }
        }

        public void Verify()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true)
                throw Analyzer.CompilationExceptions.NoNextSymbolException; //Brak kolejnego symbolu
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == false)
                throw Analyzer.CompilationExceptions.UnknownSymbolException; //Symbol nie należący do języka
            if (!Analyzer.ReadCode.IsSymbolAVariable()) throw Analyzer.CompilationExceptions.NoVariableException;
        }

        public void VerifyIfVariableIsInitialized()
        {
            if (Analyzer.ReadCode.IsSymbolAVariable() == true && Analyzer.CheckIfVariableIsInitialized())
                throw Analyzer.CompilationExceptions.NotInitializedVariableException;
        }
    }
}
