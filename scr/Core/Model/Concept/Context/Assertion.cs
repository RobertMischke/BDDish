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

		public Assertion(string labelConcept, Action action) : 
			base(labelConcept)
		{
			Action = action;
		}

		public Assertion(string labelConcept, object assertion, EqualConstraint equalTo) : 
			base(labelConcept)
		{
			Action = () => Assert.That(assertion, equalTo);
		}

		public Assertion(string labelConcept, Func<AssertionResult> func) : 
			base(labelConcept)
		{
			ActionWithResult = func;
		}

	}
}
