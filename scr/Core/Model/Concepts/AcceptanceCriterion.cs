using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class AcceptanceCriterion : SpecificationPart
	{
		public RoleList Sponsors = new RoleList();
		public Context Context;
		public AssertionList Assertions = new AssertionList();
		

		public AcceptanceCriterion(string content) : base(content)
		{			
		}

		public AcceptanceCriterion(Role demander, string acceptanceContent, AssertionList asssetions) : base(acceptanceContent)
		{
			Sponsors.Add(demander);
		}

		public AcceptanceCriterion(Role demander, Context context, string acceptanceContent)
			: base(acceptanceContent)
		{
			Context = context;
			Sponsors.Add(demander);
		}
	}
}
