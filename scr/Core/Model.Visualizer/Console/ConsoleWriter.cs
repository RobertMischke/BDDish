using System;
using BDDish.Model.Visualizer;

namespace BDDish
{
    public class ConsoleWriter
    {
        private const string IndentUserStory = " ";
        private const string IndentCustomer = " ";
        private const string IndentAceptanceCriteria = "    ";
        private const string IndentContext = "      ";
        private const string IndentAssertion = "      ";

        private readonly MethodSignatureToString _methodSignatureToString = new MethodSignatureToString();

        public void Write(Feature feature)
        {
            Console.WriteLine(feature.Label);
            WriteUserStoryInfo(feature);            
        }

        private void WriteUserStoryInfo(Feature feature)
        {
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
                WriteAssertionInfo(acceptanceCriterion);
            }
        }

        private void WriteAssertionInfo(AcceptanceCriterion acceptanceCriterion)
        {
            foreach (var assertion in acceptanceCriterion.Context.Assertions)
            {
                Console.WriteLine(IndentAssertion + assertion.LabelConcept + ": " + _methodSignatureToString.GetString(assertion.Action));
            }
        }
    }
}