using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.Model
{
	public class Assertion : ConceptNode
	{
		public Func<AssertionResult> ActionWithResult;
		public Action Action;

	    public Context Context;

		public Assertion(string labelConcept, Action action, Context context) : 
			base(labelConcept)
		{
			Action = action;
		    Context = context;
		}

        public Assertion(string labelConcept, Func<object> assertion, Func<EqualConstraint> equalTo, Context context) : 
			base(labelConcept)
		{
			Action = () => Assert.That(assertion.Invoke(), equalTo.Invoke());
            Context = context;
		}

		public Assertion(string labelConcept, Func<AssertionResult> func, Context context) : 
			base(labelConcept)
		{
			ActionWithResult = func;
            Context = context;
		}

	}
}
