using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BDDish.German;

namespace BDDish.Tests
{
	public class PlaygroundDSLGerman
	{
		[Test]
		public void Foo()
		{
			new German.
				Feature("Schnittstellen").
				UserStory("FANTASYformat v1.0").
					Als()
				
		}

	}
}
