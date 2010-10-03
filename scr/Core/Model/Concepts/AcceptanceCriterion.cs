using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class AcceptanceCriterion : SpecificationPart
	{
		public SponsorList Sponsors = new SponsorList();
		public AssertionList Assertions = new AssertionList();
		

		public AcceptanceCriterion(string content, AssertionList assertions) : base(content)
		{
			Assertions.Add(assertions);
		}

		public AcceptanceCriterion(Sponsor sponsor, string acceptanceContent, AssertionList assertions) : base(acceptanceContent)
		{
			Sponsors.Add(sponsor);
			Assertions.Add(assertions);
		}

		public AcceptanceCriterion(Sponsor sponsor, string acceptanceContent)
			: base(acceptanceContent)
		{
			Sponsors.Add(sponsor);
		}

		
	}
}
