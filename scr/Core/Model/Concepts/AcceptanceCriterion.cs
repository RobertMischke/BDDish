using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class AcceptanceCriterion : SpecificationPart
	{
		public Context Context;
		public Customer ParentCustomer;

		
		public AcceptanceCriterion(string labelConcept, string acceptanceContent, Customer parentCustomer)
			: base(labelConcept, acceptanceContent)
		{
			ParentCustomer = parentCustomer;
		}

		public void AddContext(IContextDescription contextDescription)
		{
			Context = new Context(contextDescription, this);
		}
	}
}
