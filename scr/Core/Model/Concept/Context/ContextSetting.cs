using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;

namespace BDDish.Model
{
    public class ContextSetting : ConceptNode
    {
        public Action Action;
        public Context Context;

        public ContextSetting(string labelConcept, Action action, Context context) : 
			base(labelConcept)
		{
			Action = action;
		    Context = context;
		}

    }
}
