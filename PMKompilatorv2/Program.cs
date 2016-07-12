using Autofac;
using PMKompilatorv2.LanguageElements.ExpressionsOfLanguage;
using PMKompilatorv2.LanguageElements.Instructions;
using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
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
        //public static IContainer DependencyContainer { get; set; }

        static void Main(string[] args)
        {
            /*var builder = new ContainerBuilder();

            ReadCode readCode = new ReadCode("C:/Users/drynca/Desktop/TestowyProgram.txt");
            Analyzer.test();

            builder.RegisterType<ReadCode>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<InstructionIf>().As<IInstructions>().InstancePerLifetimeScope();
            DependencyContainer = builder.Build();

            using( var scope = DependencyContainer.BeginLifetimeScope())
            {
                
                
            }*/
            //Builder.Res

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
            Analyzer.Start();

            Console.ReadKey();
        }
    }
}
