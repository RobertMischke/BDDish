using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	/// <summary>
	/// The one who is paying for a feature or demanding the feature in order to archive the development goals.
	/// </summary>
	public class Customer : SpecificationPart
	{
		private readonly ICustomerDescription _customerDescription;

		public string Name { get { return _customerDescription.Name; } set { _customerDescription.Name = value; } }
		public string Desription { get { return _customerDescription.Desription; } set { _customerDescription.Desription = value; } }

		public UserStory ParentUserStory;

		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();

		private class InternalDescription : ICustomerDescription
		{
			public string Name { get; set; }
			public string Desription { get; set; }
		}

		public Customer(string labelConcept, string labelBody, UserStory userStory) : base(labelConcept, labelBody)
		{
			_customerDescription = new InternalDescription();
			Name = labelBody;
			ParentUserStory = userStory;
		}

		public Customer(string labelConcept, ICustomerDescription customerDescription, UserStory userStory)
			: base(labelConcept, customerDescription.Name)
		{
			_customerDescription = customerDescription;
			ParentUserStory = userStory;
		}

		public void Add(AcceptanceCriterion acceptanceCriterion)
		{
			AcceptanceCriteria.Add(acceptanceCriterion);
		}
	}
}
