namespace BDDish
{
	public interface IContextDescription
	{
		string SampleDesciption { get; set; }
		
		void Setup();
	}
}