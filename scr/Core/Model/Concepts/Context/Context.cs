﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish
{
	public class Context : SpecificationPart, IContext
	{
		public string Name;
		public string Description;

		public AssertionList Assertions = new AssertionList();

		public void Create()
		{
			
		}

	}
}
