using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class AcceptanceCriterion : SpecificationPart
	{
		public RoleList Sponsors = new RoleList();
		public AssertionList Assertions = new AssertionList();
		

		public AcceptanceCriterion(string content, AssertionList assertions) : base(content)
		{
			Assertions.Add(assertions);
		}

		public AcceptanceCriterion(Role sponsor, string acceptanceContent, AssertionList assertions) : base(acceptanceContent)
		{
			Sponsors.Add(sponsor);
			Assertions.Add(assertions);
		}

		public AcceptanceCriterion(Role sponsor, string acceptanceContent)
			: base(acceptanceContent)
		{
			Sponsors.Add(sponsor);
		}

		
	}
}
