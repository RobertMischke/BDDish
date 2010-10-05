using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
	public class Für
	{
		public const string LabelConcept = "Für";

		private readonly Context _modelContext;

		public Für(Context modelContext)
		{
			_modelContext = modelContext;
		}

		public Gilt_ Gilt(Action asssertionAction)
		{
			_modelContext.Add(new Assertion(Gilt_.LabelConcept, asssertionAction, _modelContext));
			return new Gilt_(_modelContext);
		}

		public Gilt_ Gilt(string assertionA, EqualConstraint equalTo)
		{
			_modelContext.Add(Gilt_.LabelConcept, assertionA, equalTo);
			return new Gilt_(_modelContext);
		}
	}
}