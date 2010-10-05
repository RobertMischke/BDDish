using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
	public class Für
	{
		private readonly Context _modelContext;

		public Für(Context modelContext)
		{
			_modelContext = modelContext;
		}

		public Gilt_ Gilt(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(asssertionAction, _modelContext));
			return new Gilt_(_modelContext);
		}

		public Gilt_ Gilt(string assertionA, EqualConstraint equalTo)
		{
			_modelContext.Add(assertionA, equalTo);
			return new Gilt_(_modelContext);
		}
	}
}