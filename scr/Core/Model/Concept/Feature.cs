using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;

namespace BDDish.Model
{
	public class Feature : ConceptNode
	{	
		public UserStoryList UserStories = new UserStoryList();
		public CustomerList Customers = new CustomerList();
		
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


	    public AssertionList GetAllAssertions()
	    {
	        return UserStories.GetAllessertions();
	    }
	}
}
