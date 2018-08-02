using Lab42_DesignPatterns.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42_DesignPatterns.ConcreteCreator
{
    public class CoverLetter : Document
    {
        public override void BuildPage()
        {
            Pages.Add(new TargetPosition());
            Pages.Add(new PersonalStatement());
            Pages.Add(new References());
        }
    }
}
