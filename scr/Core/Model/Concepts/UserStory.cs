using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class UserStory : SpecificationPart
	{
		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();

		public UserStory(string content) : base(content)
		{
		}

		public UserStory AddAcceptanceCriterion(string content)
		{
			AcceptanceCriteria.Add(new AcceptanceCriterion(content));
			return this;
		}
	}
}
