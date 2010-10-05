using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class ModelExecuter
	{
		public void Run(Feature feature)
		{
			Console.WriteLine(feature.Label);

			foreach (var userStory in feature.UserStories)
			{
				Console.WriteLine(userStory.Label);
				WriteCustomerInfo(userStory);
			}
		}

		private void WriteCustomerInfo(UserStory userStory)
		{
			foreach (var customer in userStory.Customers)
			{
				Console.WriteLine(customer.Label);
				WriteAcceptanceInfo(customer);
			}
		}

		private void WriteAcceptanceInfo(Customer customer)
		{
			foreach (var acceptanceCriterion in customer.AcceptanceCriteria)
			{
				Console.WriteLine(acceptanceCriterion.Label);
				Console.WriteLine(acceptanceCriterion.Context);
				WriteAndExcecuteAssertion(acceptanceCriterion);
				
			}
		}

		private void WriteAndExcecuteAssertion(AcceptanceCriterion acceptanceCriterion)
		{
			foreach (var assertion in acceptanceCriterion.Context.Assertions)
			{
				Console.WriteLine(assertion.LabelConcept);

				try { assertion.Action(); }
				catch (NotImplementedException e) { }
			}
		}
	}
}
