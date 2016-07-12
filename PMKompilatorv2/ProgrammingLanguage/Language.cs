
using PMKompilatorv2.LanguageElements;
using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using PMKompilatorv2.ProgrammingLanguage.LanguageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2
{
    public class Language
    {
        public static Instructions Instructions { get { return new Instructions(); } }
        public static Expressions Expressions { get { return new Expressions(); } }
        public static CompilationErrors Errors { get { return new CompilationErrors(); } }
        public static Variable Variable { get { return new Variable(); } }
        public static Number Number { get { return new Number(); } }

        private Language()
        {

        }
    }
}
