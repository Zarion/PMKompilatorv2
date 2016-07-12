using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMKompilatorv2.LanguageAnalyzer
{
    public class CodeTree
    {
        //Wartośc przechowywana w węźle
        public string Value { get; set; }
        //Odniesienie do rodzica danego węzła
        public CodeTree Parent { get; set; }
        //Lista dzieci węzła
        private List<CodeTree> Childs;
        //Tworzenie nowego węzła
        public CodeTree(string value)
        {
            Value = value;
            Childs = new List<CodeTree>();
        }
        //Dodanie dziecka do węzła - dodaje na sam koniec listy dzieci
        public void AddChild(CodeTree child, ref CodeTree parent)
        {
            child.Parent = parent;
            Childs.Add(child);
        }

        public int NumberOfChilds
        {
            get
            {
                return Childs.Count();
            }
        }

        public string GetChildValue(int child)
        {
            return Childs.ElementAt(child - 1).Value;
        }

        public CodeTree GetChild(int child)
        {
            return Childs.ElementAt(child - 1);
        }

        public CodeTree LastChild
        {
            get
            {
                return Childs.Last();
            }
        }

        public void ShowTree(CodeTree tree)
        {
            string thisNode = "";
            thisNode += tree.Value;
            thisNode += ": ";
            int childsNumber = tree.NumberOfChilds;

            for (int i = 0; i < childsNumber; i++)
            {
                thisNode += tree.GetChildValue(i + 1);
                thisNode += " ";
                ShowTree(tree.GetChild(i + 1));
            }

            Console.WriteLine(thisNode);
        }
    }
}
