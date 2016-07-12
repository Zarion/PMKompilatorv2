﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer.Exceptions
{
    public class IncorrectExpressionException : ExceptionBase
    {
        public IncorrectExpressionException() : base("Niepoprwane wyrażenie.")
        {

        }
    }
}
