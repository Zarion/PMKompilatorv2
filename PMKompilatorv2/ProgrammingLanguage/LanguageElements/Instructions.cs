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

        public int VerifyInstruction()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.EndOfSymbols == true) return 0;
            if (Analyzer.ReadCode.CurrentSymbolCode != 1)
            {
                return 3;
            }
            else
            {
                foreach (IInstructions instruction in Language.Instructions.ListOfInstructions)
                {
                    if (Analyzer.ReadCode.CurrentSymbol == instruction.Text) return instruction.Verify();
                }
            }
            return 3;
        }
    }
}
