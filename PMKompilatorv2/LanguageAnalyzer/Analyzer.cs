using PMKompilatorv2.LanguageAnalyzer;
using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer
{
    public class Analyzer
    {
        public static ReadCode ReadCode = new ReadCode("C:/Users/drynca/Desktop/TestowyProgram.txt");
        public static List<string> InitializedVariables = new List<string>();
        public static CompilationExceptions CompilationExceptions { get { return new CompilationExceptions(); } }

        public static void Start()
        {
            while( !Analyzer.ReadCode.EndOfSymbols )
            {
                Language.Instructions.VerifyInstruction();
            }
        }

        public static void AddInitializedVariable()
        {
            if (!Analyzer.InitializedVariables.Contains(Analyzer.ReadCode.CurrentSymbol))
            {
                Analyzer.InitializedVariables.Add(Analyzer.ReadCode.CurrentSymbol);
            }
        }

        public static bool CheckIfVariableIsInitialized()
        {
            if (Analyzer.InitializedVariables.Contains(Analyzer.ReadCode.CurrentSymbol))
            {
                return true;
            }
            return false;
        }

        private Analyzer()
        {
            
        }
    }
}
