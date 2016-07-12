using PMKompilatorv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.ExpressionsOfLanguage.TwoArgumentExpressions
{
    public class TwoArgumentBaseExpression : IExpression
    {
        virtual public string Text
        {
            get
            {
                return "";
            }
        }

        public void Verify()
        {
            Language.Expressions.Verify();
            Language.Expressions.Verify();
        }
    }
}
