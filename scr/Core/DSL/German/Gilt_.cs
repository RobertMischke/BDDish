using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
	public class Gilt_
	{
		public Gilt_ Gilt(Action someAssertionMethod, string empty)
		{
			return new Gilt_();
		}

		public AkzeptanzKriterium AkzeptanzKriterium(string beschreibung)
		{
			throw new NotImplementedException();
		}

		public Kunde Als(ICustomer k2)
		{
			throw new NotImplementedException();
		}

		public Gilt_ Gilt(string assertionA, EqualConstraint equalTo)
		{
			Assert.That(assertionA, equalTo);

			return new Gilt_();
		}

		public void Execute()
		{
			throw new NotImplementedException();
		}
	}
}