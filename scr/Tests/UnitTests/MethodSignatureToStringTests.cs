using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests
{
	public class MethodSignatureToStringTests
	{
		[Test]
		public void MethodSignatureToTest()
		{
			var singatureToString = new MethodSignatureToString();
			Assert.That(singatureToString.GetString(SampleSignature), Is.EqualTo("Sample signature"));
		}

		public void SampleSignature()
		{
			
		}

	}
}
