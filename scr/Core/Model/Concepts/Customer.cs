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

		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();

		private class InternalDescription : ICustomerDescription
		{
			public string Name { get; set; }
			public string Desription { get; set; }
		}

		public Customer(string content) : base(content)
		{
			_customerDescription = new InternalDescription();
			Name = content;
		}

		public Customer(ICustomerDescription customerDescription)
		{
			_customerDescription = customerDescription;
		}

		public void Add(AcceptanceCriterion acceptanceCriterion)
		{
			AcceptanceCriteria.Add(acceptanceCriterion);
		}
	}
}
