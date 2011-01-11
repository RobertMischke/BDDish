using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model
{
	public class AcceptanceCriterionList : List<AcceptanceCriterion>
	{
	    public AssertionList GetAllAssertions()
	    {
	        var result = new AssertionList();

            foreach (var criterion in this)
                result.Add(criterion.GetAllAssertions());

            return result;
	    }
	}
}
