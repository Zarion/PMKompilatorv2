using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2
{
    public class Analyzer
    {
        public static ReadCode ReadCode = new ReadCode("C:/Users/drynca/Desktop/TestowyProgram.txt");
        public static List<string> InitializedVariables = new List<string>();

        public static void Start()
        {
            int response = -1;
            while( !Analyzer.ReadCode.EndOfSymbols )
            {
                response = Language.Instructions.VerifyInstruction();
                if (response != -1) break ;
            }

            Console.WriteLine(Language.Errors.ErrorText(response));
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
