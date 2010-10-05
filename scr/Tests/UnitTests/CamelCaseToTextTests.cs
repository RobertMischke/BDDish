using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests
{
	public class CamelCaseToTextTests
	{
		private readonly CamelCaseToText _camelCaseToText = new CamelCaseToText();

		[Test]
		public void CamelCastToTest()
		{
			Assert.That(_camelCaseToText.GetText("SomeCamelCaseText"), Is.EqualTo("Some camel case text") );
		}

	}
}
