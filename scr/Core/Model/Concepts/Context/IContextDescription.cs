namespace BDDish
{
	public interface IContextDescription
	{
		string Label { get; set; }
		string SampleDesciption { get; set; }
		
		void Setup();
	}
}