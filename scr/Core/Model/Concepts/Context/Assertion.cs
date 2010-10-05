using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish
{
	public class Assertion : SpecificationPart
	{
		public Action Action;
		public Context ParentContext;

		public Assertion(string labelConcept, Action action, Context parentContext) : 
			base(labelConcept)
		{
			Action = action;
			ParentContext = parentContext;
		}

		public Assertion(string labelConcept, string assertion, EqualConstraint equalTo, Context parentContext) : 
			base(labelConcept)
		{
			Action = () => Assert.That(assertion, equalTo);
			ParentContext = parentContext;
		}
	}
}
