using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;

namespace BDDish.Model
{
    public class Note : ConceptNode
    {
        public Note(string labelConcept) : base(labelConcept)
        {
        }

        public Note(string labelConcept, string labelBody) : base(labelConcept, labelBody)
        {
        }
    }
}
