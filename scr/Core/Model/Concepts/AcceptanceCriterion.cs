using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class AcceptanceCriterion : SpecificationPart
	{
		public RoleList Sponsors = new RoleList();

		public AcceptanceCriterion(string content) : base(content)
		{			
		}

		public AcceptanceCriterion(Role demander, string acceptanceContent) : base(acceptanceContent)
		{
			Sponsors.Add(demander);
		}
	}
}
