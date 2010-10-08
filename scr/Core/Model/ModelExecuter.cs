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

		private readonly List<Action> _actionsToExecute = new List<Action>();

		private readonly MethodSignatureToString _methodSignatureToString = new MethodSignatureToString();

		public void Run(Feature feature)
		{
			Console.WriteLine(feature.Label);

			foreach (var userStory in feature.UserStories)
			{
				Console.WriteLine(IndentUserStory + userStory.Label);
				WriteCustomerInfo(userStory);
			}

			ExecuteAllAssertionAction();

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
				WriteAssertionInfo(acceptanceCriterion);
			}
		}

		private void WriteAssertionInfo(AcceptanceCriterion acceptanceCriterion)
		{
			foreach (var assertion in acceptanceCriterion.Context.Assertions)
			{
				Console.WriteLine(IndentAssertion + assertion.LabelConcept + ": " + _methodSignatureToString.GetString(assertion.Action));
				_actionsToExecute.Add(assertion.Action);
			}
		}

		private void ExecuteAllAssertionAction()
		{
			_actionsToExecute.ForEach(action => {
				try { action(); }
				catch (NotImplementedException e) { }
			});

		}



	}
}
