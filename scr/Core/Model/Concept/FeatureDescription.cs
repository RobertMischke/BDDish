using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;

namespace BDDish.Model
{
    public class FeatureDescription : ConceptNode
    {
        public FeatureDescription(string labelConcept, string labelBody)
            : base(labelConcept, labelBody)
		{
		}        
    }
}
