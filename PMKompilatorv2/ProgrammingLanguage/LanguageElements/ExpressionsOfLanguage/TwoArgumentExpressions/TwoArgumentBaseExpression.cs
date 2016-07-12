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

        public int Verify()
        {
            int response = 2;
            response = Language.Expressions.OneArgumentExpresion.Verify();
            if( response != -1)
            {
                return response;
            }
            else
            {
                return Language.Expressions.OneArgumentExpresion.Verify();
            }
        }
    }
}
