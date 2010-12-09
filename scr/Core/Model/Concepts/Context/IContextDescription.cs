namespace BDDish.Model.Concept
{
	public interface IContextDescription
	{
		string SampleDesciption { get; set; }
		
		void Setup();
	}
}