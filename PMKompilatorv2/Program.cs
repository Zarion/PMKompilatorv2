using Autofac;
using PMKompilatorv2.LanguageAnalyzer;
using PMKompilatorv2.LanguageAnalyzer.Exceptions;
using PMKompilatorv2.LanguageElements.ExpressionsOfLanguage;
using PMKompilatorv2.LanguageElements.Instructions;
using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using PMKompilatorv2.ProgrammingLanguage.LanguageElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*foreach(IExpression expression in Language.Expressions.ListOfExpressions)
            {
                Console.WriteLine(expression.Text);
            }

            foreach(IInstructions instruction in Language.Instructions.ListOfInstructions)
            {
                Console.WriteLine(instruction.Text);
            }*/

            /*for( int i = 0; i < Analyzer.ReadCode.SymbolsCount; ++i )
            {
                Console.WriteLine("Symbol: " + Analyzer.ReadCode.CurrentSymbol);
                Console.WriteLine("Kod: " + Analyzer.ReadCode.CurrentSymbolCode.ToString());
                Console.WriteLine("Dlugosc stringa: " + Analyzer.ReadCode.CurrentSymbol.Length);
                Console.WriteLine("");
                Analyzer.ReadCode.ReadNewSymbol();
            }*/
            try
            {
                Analyzer.Start();
                Console.WriteLine("Kompuilacja zakończona sukcesem");
            }
            catch(ExceptionBase e)
            {
                Console.WriteLine(e.Message + " Linia: " + Analyzer.ReadCode.CurrentLine + ". Symbol: " + Analyzer.ReadCode.NumberOfSymbolInCurrentLine);
            }


            Console.ReadKey();

        }

        
    }
}
