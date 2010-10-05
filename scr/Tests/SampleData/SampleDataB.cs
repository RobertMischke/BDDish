using System;

namespace BDDish.Tests
{
	public class SampleDataB : IContextDescription
	{
		public string Name { get; set; }
		public string Desciption { get; set; }

		public void Create()
		{
			throw new NotImplementedException();
		}

		public SampleDataB()
		{
			Name = "SampleDataB";
			Desciption = "Sampel data for B";
		}
	}
}