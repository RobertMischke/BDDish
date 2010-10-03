using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.German
{
	public class Für
	{
		public Gilt_ Gilt(Action asssertionMethod)
		{
			return new Gilt_();
		}

		public Gilt_ Gilt(string assertionA, EqualConstraint equalTo)
		{
			Assert.That(assertionA, equalTo);
			
			return new Gilt_();
		}
	}
}