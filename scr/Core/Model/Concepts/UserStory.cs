using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class UserStory : SpecificationPart
	{
		public RoleList Sponsors = new RoleList();
		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();

		public UserStory(Role sponsor, string content): base(content)
		{
			Sponsors.Add(sponsor);
		}

		
		public UserStory AddAcceptanceCriterion(
			Role sponsor, 
			string acceptanceContent,
			AssertionList assertions)
		{
			AcceptanceCriteria.Add(new AcceptanceCriterion(sponsor, acceptanceContent, assertions));
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
