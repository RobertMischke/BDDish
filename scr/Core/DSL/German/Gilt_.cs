using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
	public class Gilt_
	{
		private readonly Context _modelContext;

		public Gilt_(Context modelContext)
		{
			_modelContext = modelContext;
		}

		public Gilt_ Gilt(string assertionA, EqualConstraint equalTo)
		{
			Assert.That(assertionA, equalTo);

			return new Gilt_(_modelContext);
		}

		public Gilt_ Gilt(Action someAssertionMethod, string empty)
		{
			return new Gilt_(_modelContext);
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			//return new AkzeptanzKriterium();
			throw new NotImplementedException();
		}

		public Kunde Als(ICustomerDescription k2)
		{
			throw new NotImplementedException();
		}

		public void Execute()
		{
			throw new NotImplementedException();
		}
	}
}