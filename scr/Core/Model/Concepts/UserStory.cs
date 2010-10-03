using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class UserStory : SpecificationPart
	{
		public CustomerList Customers = new CustomerList();
		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();

		public UserStory(Customer customer, string content): base(content)
		{
			Customers.Add(customer);
		}

		
		public UserStory AddAcceptanceCriterion(
			Customer customer, 
			string acceptanceContent,
			AssertionList assertions)
		{
			AcceptanceCriteria.Add(new AcceptanceCriterion(customer, acceptanceContent, assertions));
			return this;
		}

		public UserStory AddAcceptanceCriterion(
			string acceptanceContent,
			AssertionList assertions)
		{
			AcceptanceCriteria.Add(new AcceptanceCriterion(acceptanceContent, assertions));
			return this;
		}

	}
}
