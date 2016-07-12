using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.ProgrammingLanguage.LanguageElements
{
    public class CompilationErrors
    {
        //Funkcja zwracjąca tekst do konkretnego błędu
        public string ErrorText(int error)
        {
            int currentLine = 0;
            switch (error)
            {
                case -1:
                    return "Kompilacja zakończona sukcesem!";
                case 0:
                    return "Niespodziewane zakończenie programu. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                case 1:
                    return "Po słowie let powinna występować zmienna. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                case 2:
                    return "Błędne wyrażenie. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                case 3:
                    return "Brak rozpoczęcia nowej instrukcji. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                case 4:
                    return "Nieznany symbol. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                case 5:
                    return "Zmienna nie została zainicjalizowana żadną wartością. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                case 6:
                    return "Dzielenie przez 0. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                case 7:
                    return "Brak wyrażenia. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
                default:
                    return "Nieznany problem. Linia: " + currentLine.ToString() + ". Numer znaku: " + Analyzer.ReadCode.CurrentIndex.ToString();
            }
        }

    }
}
