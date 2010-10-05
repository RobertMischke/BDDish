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
			feature.AddSponsor(new Customer("SampleCustomer"));
			feature.AddUserStory(
				new UserStory(new Customer("CompanyA"), "Export invoice to FANTASYformat")
					.AddAcceptanceCriterion(
						new Customer("CompanyA"), 
						"Validate the created document against XSD.", 
						new AssertionList(
							new Assertion(()=> Console.WriteLine("assertion1")))
						)
					.AddAcceptanceCriterion(
						new Customer("CompanyA"), 
						"The invoice properties are completly exported to fantasy format",
						new AssertionList(
							new Assertion(() => Console.WriteLine("assertion2"))))
					.AddAcceptanceCriterion(
						new Customer("CompanyA"), 
						"The invoice properties are completly exported to fantasy format", 
						new AssertionList()));

		}

	}
}
