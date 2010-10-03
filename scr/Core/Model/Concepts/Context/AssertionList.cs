using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class AssertionList : List<Assertion>
	{
		public AssertionList(params Assertion[] assertions)
		{
			foreach(var assertion in assertions)
				Add(assertion);
		}

		public void Add(AssertionList assertions)
		{
			AddRange(assertions);
		}
	}
}
