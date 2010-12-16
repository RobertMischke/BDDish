using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model
{
	public class AcceptanceCriterion : SpecificationNode
	{
		public Context Context;
		public Customer ParentCustomer;
		
		public AcceptanceCriterion(string labelConcept, string acceptanceContent, Customer parentCustomer)
			: base(labelConcept, acceptanceContent)
		{
			ParentCustomer = parentCustomer;
		}

		public void AddContext(string labelConcept, IContextDescription contextDescription)
		{
			Context = new Context(labelConcept, contextDescription, this);
		}

	    public AssertionList GetAllAssertions()
	    {
	        return Context.GetAllAssertions();
	    }
	}
}
