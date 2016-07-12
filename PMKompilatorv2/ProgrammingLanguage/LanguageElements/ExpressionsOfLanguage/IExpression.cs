using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageElements.ExpressionsOfLanguage
{
    public interface IExpression
    {
        //Text zwraca prezentacje symbolu, np. if, while, -, +, sin
        string Text
        {
            get;
        }

        //Funkcja weryfikująca poprawność wyrażenia
        void Verify();
    }
}
