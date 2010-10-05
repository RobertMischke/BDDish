using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class Feature : SpecificationPart
	{	
		public UserStoryList UserStories = new UserStoryList();
		public CustomerList Customers = new CustomerList();

		/// <summary>
		/// Acceptance criteria directly assigned to this Feature. 
		/// </summary>
		/// <remarks>
		/// These criteria don't have a user stories  assigned.
		/// </remarks>
		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();
		

		public Feature(string labelConcept, string labelBody) : base(labelConcept, labelBody)
		{
		}

		public Feature AddUserStory(params UserStory[] userStories)
		{
			foreach(var userStory in userStories)
				UserStories.Add(userStory);

			return this;
		}

		public Feature AddSponsor(Customer customer)
		{
			Customers.Add(customer);
			return this;
		}

	}
}
