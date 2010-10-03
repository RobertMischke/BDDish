using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests
{
	public class Playground
	{
		[Test]
		public void Playing_arround_with_the_model()
		{

			var feature = new Feature("FANTASYformat v1.0");
			feature.AddSponsor(new Sponsor("SampleCustomer"));
			feature.AddUserStory(
				new UserStory(new Sponsor("CompanyA"), "Export invoice to FANTASYformat")
					.AddAcceptanceCriterion(
						new Sponsor("CompanyA"), 
						"Validate the created document against XSD.", 
						new AssertionList(
							new Assertion())
						)
					.AddAcceptanceCriterion(
						new Sponsor("CompanyA"), 
						"The invoice properties are completly exported to fantasy format", 
						new AssertionList(new Assertion()))
					.AddAcceptanceCriterion(
						new Sponsor("CompanyA"), 
						"The invoice properties are completly exported to fantasy format", 
						new AssertionList()));

		}

	}
}
