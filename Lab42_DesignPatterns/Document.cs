using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42_DesignPatterns
{
    public abstract class Document
    {
        public Document()
        {
            BuildPage();
        }
        public abstract void BuildPage();
        public List<Page> Pages = new List<Page>();

    }
}
