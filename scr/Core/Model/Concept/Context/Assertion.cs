using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.Model
{
	public class Assertion : SpecificationNode
	{
		public Func<AssertionResult> ActionWithResult;
		public Action Action;
		public Context ParentContext;

		public Assertion(string labelConcept, Action action, Context parentContext) : 
			base(labelConcept)
		{
			Action = action;
			ParentContext = parentContext;
		}

		public Assertion(string labelConcept, object assertion, EqualConstraint equalTo, Context parentContext) : 
			base(labelConcept)
		{
			Action = () => Assert.That(assertion, equalTo);
			ParentContext = parentContext;
		}

		public Assertion(string labelConcept, Func<AssertionResult> func, Context parentContext) : 
			base(labelConcept)
		{
			ActionWithResult = func;
			ParentContext = parentContext;
		}

	}
}
