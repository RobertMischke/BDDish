using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class ModelExecuter
	{
		private const string IndentUserStory = " ";
		private const string IndentCustomer = " ";
		private const string IndentAceptanceCriteria = "    ";
		private const string IndentContext = "      ";
		private const string IndentAssertion = "      ";

		public void Run(Feature feature)
		{
			Console.WriteLine(feature.Label);

			foreach (var userStory in feature.UserStories)
			{
				Console.WriteLine(IndentUserStory + userStory.Label);
				WriteCustomerInfo(userStory);
			}
		}

		private void WriteCustomerInfo(UserStory userStory)
		{
			foreach (var customer in userStory.Customers)
			{
				Console.WriteLine(IndentCustomer + customer.Label);
				WriteAcceptanceInfo(customer);
			}
		}

		private void WriteAcceptanceInfo(Customer customer)
		{
			foreach (var acceptanceCriterion in customer.AcceptanceCriteria)
			{
				Console.WriteLine(IndentAceptanceCriteria + acceptanceCriterion.Label);
				Console.WriteLine(IndentContext + acceptanceCriterion.Context.Label);
				WriteAndExcecuteAssertion(acceptanceCriterion);
				
			}
		}

		private void WriteAndExcecuteAssertion(AcceptanceCriterion acceptanceCriterion)
		{
			foreach (var assertion in acceptanceCriterion.Context.Assertions)
			{
				Console.WriteLine(IndentAssertion + assertion.LabelConcept);

				try { assertion.Action(); }
				catch (NotImplementedException e) { }
			}
		}
	}
}
