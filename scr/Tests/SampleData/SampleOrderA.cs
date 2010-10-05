using System;

namespace BDDish.Tests
{
	public class SampleOrderA : IContextDescription 
	{
		public string Name { get; set; }
		public string Desciption { get; set; }

		public void Setup()
		{
		}

		public SampleOrderA()
		{
			Name = GetType().Name;
			Desciption =
				@"3 Positionen
				Position1: Id = 1
				Position2: Id = 2
				Position3: Id = 3

				Auftraggeber.Id = 1
				Auftraggeber.Name = Irgendeinname";
		}

	}
}