using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Visualizer;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace BDDish.Tests
{
	public class Assertion_actions_to_meaningfull_name
	{
		readonly AssertionActionToString _assertionActionToString = new AssertionActionToString();

		[Test]
		public void Method_name_to_string()
		{
			Assert.That(_assertionActionToString.GetString(SampleSignature), Is.EqualTo("Sample signature"));
		}

		public void SampleSignature(){}


		[Test]
		public void Anonymous_action_to_string()
		{
			//TODO
			Action action = () => Assert.That((object)"test", Is.EqualTo("test"));
            Assert.That(_assertionActionToString.GetString(action), Is.EqualTo("unknown assertion"));
		}

        Action test_ = () => { };
        Action we_expect_something = ()=>{};

        [Test]
        public void Anonymous_action_to_string_if_it_assigned_to_a_property()
        {
            Assert.That(_assertionActionToString.GetString(we_expect_something), Is.EqualTo("we expect something"));
        }

	}
}