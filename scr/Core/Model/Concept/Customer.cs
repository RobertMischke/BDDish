using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Tree;
using BDDish.Model.Visualizer;

namespace BDDish.Model
{
	/// <summary>
	/// The one who is paying for a feature or demanding the feature in order to archive the development goals.
	/// </summary>
	public class Customer : ConceptNode
	{
		private readonly ICustomerDescription _customerDescription;

		public string Desription { get { return _customerDescription.About; } set { _customerDescription.About = value; } }

		public UserStory ParentUserStory;

		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();

		private class InternalDescription : ICustomerDescription
		{
			public string About { get; set; }
		}

		public Customer(string labelConcept, string labelBody, UserStory userStory) : base(labelConcept, labelBody)
		{
			_customerDescription = new InternalDescription();
			ParentUserStory = userStory;
		}

		public Customer(string labelConcept, ICustomerDescription customerDescription, UserStory userStory)
			: base(labelConcept, new CamelCaseToText().GetTextCapitalized(customerDescription.GetType().Name))
		{
			_customerDescription = customerDescription;
			ParentUserStory = userStory;
		}

		public void Add(AcceptanceCriterion acceptanceCriterion)
		{
			AcceptanceCriteria.Add(acceptanceCriterion);
		}

	    public AssertionList GetAllAssertions()
	    {
	        return AcceptanceCriteria.GetAllAssertions();
	    }
	}
}
