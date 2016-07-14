using PMKompilatorv2.LanguageElements.ExpressionsOfLanguage;
using PMKompilatorv2.LanguageElements.InstructionsOfLanguage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer
{
    public class ReadCode
    {
        private string filePath;
        private List<string> Symbols;
        private int currentIndex;
        private List<int> lines;

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

        public void ReadPreviousSymbol()
        {
            this.currentIndex -= 1;
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

        public int CurrentLine
        {
            get
            {
                int i = 0;
                List<int> test = Analyzer.ReadCode.lines;
                for( i = 0; i < this.lines.Count-1; ++i)
                {
                    if (this.currentIndex <= lines[i]) return i+1;
                }
                return i+2;
            }
        }

        public int NumberOfSymbolInCurrentLine
        {
            get
            {
                if (CurrentLine != 0) return this.currentIndex - this.lines[CurrentLine - 2];
                return this.currentIndex + 1;
            }
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
                if (Regex.IsMatch(this.Symbols[index], Language.Variable.Text)) return 4;
                if (this.Symbols[index].Equals(";")) return 6;
                foreach (IInstructions instruction in Language.Instructions.ListOfInstructions)
                    if (instruction.Text.Equals(this.Symbols[index])) return 1;
                foreach (IExpression expresion in Language.Expressions.ListOfOneArgumentExpressions)
                    if (expresion.Text.Equals(this.Symbols[index])) return 2;
                foreach (IExpression expresion in Language.Expressions.ListOfTwoArgumentExpressions)
                    if (expresion.Text.Equals(this.Symbols[index])) return 3;
                if (Regex.IsMatch(this.Symbols[index], Language.Number.Text)) return 5;
            }

            return 0;
        }

        public ReadCode(string filePath)
        {
            currentIndex = -1;
            Symbols = new List<string>();
            lines = new List<int>();
            this.filePath = filePath;
            string symbol = "";
            string code = File.ReadAllText(filePath);
            for (int i = 0; i < code.Length; i++)
            {
                if( code[i].ToString().Equals(" ") || code[i].ToString().Equals("\u0009") || code[i].ToString().Equals("\n") || code[i].ToString().Equals("\r"))
                {
                    if(code[i].ToString().Equals("\n"))
                    {
                        this.lines.Add(this.Symbols.Count - 1);
                    }
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
            if (this.lines.Count == 0) this.lines.Add(Symbols.Count - 1);
        }
        
    }
}
