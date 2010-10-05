using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish
{
	public class Assertion
	{
		public Action Action;
		
		public Context ParentContext;

		public Assertion(Action action, Context parentContext)
		{
			Action = action;
			ParentContext = parentContext;
		}

		public Assertion(string assertion, EqualConstraint equalTo)
		{
			Action = () => Assert.That(assertion, equalTo);
		}
	}
}
