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
			feature.AddDemander(new Role("SampleCustomer"));
			feature.AddUserStory(
				new UserStory("Export invoice to FANTASYformat")
					.AddAcceptanceCriterion("Validate the created document against XSD.")
					.AddAcceptanceCriterion("The invoice properties are completly exported to fantasy format")
					.AddAcceptanceCriterion(
						new Role("CompanyA"), "The invoice properties are completly exported to fantasy format"));



		}

	}
}
