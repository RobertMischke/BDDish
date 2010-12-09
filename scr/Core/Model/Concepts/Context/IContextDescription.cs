namespace BDDish.Model
{
	public interface IContextDescription
	{
		string SampleDesciption { get; set; }
		
		void Setup();
	}
}