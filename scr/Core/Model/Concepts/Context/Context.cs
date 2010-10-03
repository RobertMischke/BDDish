using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class Context : SpecificationPart 
	{
		public string Name;
		public string Description;

		public ContextAssertionList Assertions = new ContextAssertionList();

		public void Setup(){}



	}
}
