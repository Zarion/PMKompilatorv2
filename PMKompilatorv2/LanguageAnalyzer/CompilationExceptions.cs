using PMKompilatorv2.LanguageAnalyzer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer
{
    public class CompilationExceptions
    {
        public NoExpressionException NoExpressionException { get { return new NoExpressionException(); } }
        public NoNextSymbolException NoNextSymbolException { get { return new NoNextSymbolException(); } }
        public NotInitializedVariableException NotInitializedVariableException { get { return new NotInitializedVariableException(); } }
        public UnknownSymbolException UnknownSymbolException { get { return new UnknownSymbolException(); } }
        public IncorrectExpressionException IncorrectExpressionException { get { return new IncorrectExpressionException(); } }
        public NoVariableException NoVariableException { get { return new NoVariableException(); } }
        public NoNumberException NoNumberException { get { return new NoNumberException(); } }
    }
}
