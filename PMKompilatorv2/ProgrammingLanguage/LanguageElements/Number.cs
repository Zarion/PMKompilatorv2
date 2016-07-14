using PMKompilatorv2.LanguageAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.ProgrammingLanguage.LanguageElements
{
    public class Number
    {
        public string Text
        {
            get
            {
                return "^[0-9]+(.[0-9]+)?$";
            }
        }

        public void Verify()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true)
                throw Analyzer.CompilationExceptions.NoNextSymbolException; //Brak kolejnego symbolu
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == false)
                throw Analyzer.CompilationExceptions.UnknownSymbolException; //Symbol nie należący do języka
            if (!Analyzer.ReadCode.IsSymbolANumber()) throw Analyzer.CompilationExceptions.NoNumberException;
        }
    }
}
