using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class UserStory : SpecificationPart
	{
		public SponsorList Sponsors = new SponsorList();
		public AcceptanceCriterionList AcceptanceCriteria = new AcceptanceCriterionList();

		public UserStory(Sponsor sponsor, string content): base(content)
		{
			Sponsors.Add(sponsor);
		}

		
		public UserStory AddAcceptanceCriterion(
			Sponsor sponsor, 
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
