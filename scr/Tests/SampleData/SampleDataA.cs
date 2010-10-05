using System;

namespace BDDish.Tests
{
	public class SampleDataA : IContextDescription 
	{
		public string Name { get; set; }
		public string Desciption { get; set; }

		public void Create()
		{
			throw new NotImplementedException();
		}

		public SampleDataA()
		{
			Name = "SampleDataA";
			Desciption = "Sampel data for A";
		}

	}
}