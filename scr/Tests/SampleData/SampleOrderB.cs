﻿using System;

namespace BDDish.Tests
{
	public class SampleOrderB : IContextDescription
	{
		public string Name { get; set; }
		public string Desciption { get; set; }

		public void Setup()
		{
			
		}

		public SampleOrderB()
		{
			Name = GetType().Name;
			Desciption =
				@"
				Nur kleine Variation zu SampleOrderA

				3 Positionen
				Position1: Id = 1
				Position2: Id = 2
				Position3: Id = 3

				Auftraggeber.Id = 1
				Auftraggeber.Name = Irgendeinname";
		}
	}
}