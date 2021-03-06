﻿using PMKompilatorv2.LanguageAnalyzer;
using PMKompilatorv2.LanguageElements.ExpressionsOfLanguage;
using PMKompilatorv2.LanguageElements.ExpressionsOfLanguage.OneArgumentExpressions;
using PMKompilatorv2.LanguageElements.ExpressionsOfLanguage.TwoArgumentExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements
{
    public class Expressions
    {
        public IExpression OneArgumentExpresion { get { return new OneArgumentBaseExpression(); } }
        public IExpression TwoArgumentExpresion { get { return new TwoArgumentBaseExpression(); } }
        public IExpression Negation { get { return new NegationExpression(); } }
        public IExpression Exclamation { get { return new ExclamationExpression(); } }
        public IExpression Absolute { get { return new AbsoluteExpression(); } }
        public IExpression SqaureRoot { get { return new SquareRootExpression(); } }
        public IExpression Sinus { get { return new SinusExpression(); } }
        public IExpression Cosinus { get { return new CosinusExpression(); } }
        public IExpression Division { get { return new DivisionExpression(); } }
        public IExpression Minus { get { return new MinusExpression(); } }
        public IExpression Multiplication { get { return new MultiplicationExpression(); } }
        public IExpression Plus { get { return new PlusExpression(); } }
        public List<IExpression> ListOfOneArgumentExpressions;
        public List<IExpression> ListOfTwoArgumentExpressions;

        public Expressions()
        {
            ListOfOneArgumentExpressions = new List<IExpression>();
            ListOfOneArgumentExpressions.Add(Negation);
            ListOfOneArgumentExpressions.Add(Exclamation);
            ListOfOneArgumentExpressions.Add(Absolute);
            ListOfOneArgumentExpressions.Add(SqaureRoot);
            ListOfOneArgumentExpressions.Add(Sinus);
            ListOfOneArgumentExpressions.Add(Cosinus);
            ListOfTwoArgumentExpressions = new List<IExpression>();
            ListOfTwoArgumentExpressions.Add(Division);
            ListOfTwoArgumentExpressions.Add(Minus);
            ListOfTwoArgumentExpressions.Add(Multiplication);
            ListOfTwoArgumentExpressions.Add(Plus);
        }

        public void Verify()
        {
            Analyzer.ReadCode.ReadNewSymbol();
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == true)
                throw Analyzer.CompilationExceptions.NoNextSymbolException; //Brak kolejnego symbolu
            if (Analyzer.ReadCode.IsSymbolIncorrect() == true && Analyzer.ReadCode.EndOfSymbols == false)
                throw Analyzer.CompilationExceptions.UnknownSymbolException; //Symbol nie należący do języka
            if (Analyzer.ReadCode.IsSymbolAnOneArgumentExpresion() == false && Analyzer.ReadCode.IsSymbolAnTwoArgumentExpresion() == false
                && Analyzer.ReadCode.IsSymbolANumber() == false && Analyzer.ReadCode.IsSymbolAVariable() == false) throw Analyzer.CompilationExceptions.NoExpressionException;
            if (Analyzer.ReadCode.IsSymbolAVariable() == true)
            {
                Language.Variable.VerifyIfVariableIsInitialized();
                Analyzer.ReadCode.ReadPreviousSymbol();
                Language.Variable.Verify();
            }
            if (Analyzer.ReadCode.IsSymbolANumber() == true)
            {
                Analyzer.ReadCode.ReadPreviousSymbol();
                Language.Number.Verify();
            }
            if (Analyzer.ReadCode.IsSymbolAnOneArgumentExpresion() == true) Language.Expressions.OneArgumentExpresion.Verify();
            if (Analyzer.ReadCode.IsSymbolAnTwoArgumentExpresion() == true) Language.Expressions.TwoArgumentExpresion.Verify();
        }
    }
}
