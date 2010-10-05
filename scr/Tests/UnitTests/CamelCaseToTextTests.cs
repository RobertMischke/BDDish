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

		[Test]
		public void UpperCaseWordsInText_ShouldStayUpperCase()
		{
			Assert.That(_camelCaseToText.GetText("SomeCAMELCase"), Is.EqualTo("Some CAMEL case"));
			Assert.That(_camelCaseToText.GetText("SOMECAMELCASE"), Is.EqualTo("SOMECAMELCASE")); //edge cases
		}

		[Test]
		public void NumberShouldBeConsideredAsWords()
		{
			Assert.That(_camelCaseToText.GetText("SomeCamel3Case"), Is.EqualTo("Some camel 3 case"));
			Assert.That(_camelCaseToText.GetText("SomeCamel34Case"), Is.EqualTo("Some camel 34 case"));
			Assert.That(_camelCaseToText.GetText("SomeCamel346Case"), Is.EqualTo("Some camel 346 case"));
		}

	}
}
