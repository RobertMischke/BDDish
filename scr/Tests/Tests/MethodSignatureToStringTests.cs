using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Visualizer;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.Tests
{
	public class MethodSignatureToStringTests
	{
		readonly MethodSignatureToString _signatureToString = new MethodSignatureToString();

		[Test]
		public void Method_signature_to_string()
		{
			Assert.That(_signatureToString.GetString(SampleSignature), Is.EqualTo("Sample signature"));
		}

		public void SampleSignature(){}


		[Test]
		public void Action_signature_to_string()
		{
			//TODO
			Action action = () => Assert.That((object)"test", Is.EqualTo("test"));
            Assert.That(_signatureToString.GetString(action), Is.EqualTo("unknown assertion"));
		}

	}
}