using PMKompilatorv2.LanguageAnalyzer;
using PMKompilatorv2.LanguageElements.Instructions;
using PMKompilatorv2.ProgrammingLanguage.LanguageElements.InstructionsOfLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.InstructionsOfLanguage
{
    public class Instructions
    {
        /*Wszystkie instrukcje dostępne w języku.
          Każda instrukcja, aby była widoczna dla kompilatora, musi zostać
          zdefiniowana i dodana do listy instrukcji*/
        public IInstructions Let { get { return new InstructionLet(); } }
        public IInstructions If { get { return new InstructionIf(); } }
        public IInstructions Input { get { return new InstructionInput(); } }
        public IInstructions Print { get { return new InstructionPrint(); } }
        public IInstructions While { get { return new InstructionWhile(); } }
        public IInstructions Nul { get { return new InstructionNul(); } }
        public List<IInstructions> ListOfInstructions;

        public Instructions()
        {
            ListOfInstructions = new List<IInstructions>();
            ListOfInstructions.Add(Let);
            ListOfInstructions.Add(If);
            ListOfInstructions.Add(Input);
            ListOfInstructions.Add(Print);
            ListOfInstructions.Add(While);
            ListOfInstructions.Add(Nul);
        }

        /*Funkcja sprawdza czy kolejny symbol jest rozpoczęciem nowej instruckji
          oraz wywołuje odpowiednią funckje weryfikującą dla instukcji*/
        public void VerifyInstruction()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true)
                throw Analyzer.CompilationExceptions.NoNextSymbolException; //Brak kolejnego symbolu
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == false)
                throw Analyzer.CompilationExceptions.UnknownSymbolException; //Symbol nie należący do języka
            if (Analyzer.ReadCode.CurrentSymbolCode != 1)
            {
                throw Analyzer.CompilationExceptions.NoNewInstructionException;
            }
            else
            {
                foreach (IInstructions instruction in Language.Instructions.ListOfInstructions)
                {
                    if (Analyzer.ReadCode.CurrentSymbol == instruction.Text) instruction.Verify();
                }
            }
        }
    }
}
