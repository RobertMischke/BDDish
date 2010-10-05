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

			var customer1 = new Customer("CompanyA");
			var customer2 = new Customer("CompanyB");

			var feature = new Feature("FANTASYformat v1.0");
			feature.AddSponsor(new Customer("SampleCustomer"));
			feature.AddUserStory();

			var userStory = new UserStory(new Customer("CompanyA"), "Export invoice to FANTASYformat");

			//var acceptanceCriterion1 = new AcceptanceCriterion(customer1, "Validate the created document against XSD.");
			//acceptanceCriterion1.Context = new Context(acceptanceCriterion1);
			//            new AssertionList(
			//                new Assertion(()=> Console.WriteLine("assertion1"), null))
			//            );
			
			//var acceptanceCriterion2 = new AcceptanceCriterion((
			//            new Customer("CompanyA"), 
			//            "The invoice properties are completly exported to fantasy format",
			//            new AssertionList(
			//                new Assertion(() => Console.WriteLine("assertion2"))))
			
			//var acceptanceCriterion3 = new AcceptanceCriterion((
			//            new Customer("CompanyA"), 
			//            "The invoice properties are completly exported to fantasy format", 
			//            new AssertionList())

		}

	}
}
