﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.ExpressionsOfLanguage.TwoArgumentExpressions
{
    public class DivisionExpression : TwoArgumentBaseExpression
    {
        override public string Text
        {
            get
            {
                return "/";
            }
        }
    }
}
