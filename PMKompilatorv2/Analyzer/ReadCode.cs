using PMKompilatorv2.LanguageElements.ExpressionsOfLanguage;
using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PMKompilatorv2
{
    public class ReadCode
    {
        private string filePath;
        private List<string> Symbols;
        private int currentIndex;

        public bool EndOfSymbols
        {
            get
            {
                if (currentIndex < Symbols.Count - 1) return false;
                return true;
            }
        }

        public int CurrentIndex
        {
            get
            {
                return currentIndex;
            }

            private set
            {
                this.currentIndex = value;
            }
        }

        public string CurrentSymbol
        {
            get
            {
                return Symbols[currentIndex];
            }
        }

        public string NextSymbol
        {
            get
            {
                if (this.currentIndex + 1 < this.Symbols.Count) return this.Symbols[this.currentIndex + 1];
                return "NULL";
            }
        }

        public string PreviousSymbol
        {
            get
            {
                if (this.currentIndex - 1 >= 0) return this.Symbols[this.currentIndex - 1];
                return "NULL";
            }
        }

        public int CurrentSymbolCode
        {
            get
            {
                return symbolCode(this.currentIndex);
            }
        }

        public int NextSymbolCode
        {
            get
            {
                return symbolCode(this.currentIndex + 1);
            }
        }

        public int PreviousSymbolCode
        {
            get
            {
                return symbolCode(this.currentIndex - 1);
            }
        }

        public int SymbolsCount
        {
            get
            {
                return this.Symbols.Count;
            }
        }

        public void ReadNewSymbol()
        {
            this.currentIndex += 1;
        }

        public bool IsSymbolAnInstruction()
        {
            if (CurrentSymbolCode == 1) return true;
            return false;
        }

        public bool IsSymbolAnOneArgumentExpresion()
        {
            if (CurrentSymbolCode == 2) return true;
            return false;
        }

        public bool IsSymbolAnTwoArgumentExpresion()
        {
            if (CurrentSymbolCode == 3) return true;
            return false;
        }

        public bool IsSymbolAVariable()
        {
            if (CurrentSymbolCode == 4) return true;
            return false;
        }

        public bool IsSymbolANumber()
        {
            if (CurrentSymbolCode == 5) return true;
            return false;
        }

        public bool IsSymbolIncorrect()
        {
            if (CurrentSymbolCode == 0) return true;
            return false;
        }

        /*Funkcja zwracająca informacje o tym, jaką częścią składni jest sumbol
        w postaci cyfry reprezentującej konkretną część.
        1 - instrukcja
        2 - operator jednoargumentowy
        3 - operator dwuargumentowy
        4 - zmienna
        5 - liczba
        6 - średnik*/
        private int symbolCode(int index)
        {
            
            if( index >=0 && index < this.Symbols.Count)
            {
                if (Regex.IsMatch(this.Symbols[index], Language.Variable)) return 4;
                if (this.Symbols[index].Equals(";")) return 6;
                foreach (IInstructions instruction in Language.Instructions.ListOfInstructions)
                    if (instruction.Text.Equals(this.Symbols[index])) return 1;
                foreach (IExpression expresion in Language.Expressions.ListOfOneArgumentExpressions)
                    if (expresion.Text.Equals(this.Symbols[index])) return 2;
                foreach (IExpression expresion in Language.Expressions.ListOfTwoArgumentExpressions)
                    if (expresion.Text.Equals(this.Symbols[index])) return 3;
                if (Regex.IsMatch(this.Symbols[index], Language.Number)) return 5;
            }

            return 0;
        }

        public ReadCode(string filePath)
        {
            currentIndex = -1;
            Symbols = new List<string>();
            this.filePath = filePath;
            string symbol = "";
            string code = File.ReadAllText(filePath);
            for (int i = 0; i < code.Length; i++)
            {
                if( code[i].ToString().Equals(" ") || code[i].ToString().Equals("\u0009") || code[i].ToString().Equals("\n") || code[i].ToString().Equals("\r"))
                {
                    if (symbol.Length > 0)
                    {
                        Symbols.Add(symbol);
                        symbol = "";
                    }
                }else
                {
                    symbol = symbol + code[i].ToString();
                }
            }

            if (symbol.Length > 0)
            {
                Symbols.Add(symbol);
                symbol = "";
            }
        }
        
    }
}
