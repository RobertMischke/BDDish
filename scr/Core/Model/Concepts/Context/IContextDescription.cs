namespace BDDish
{
	public interface IContextDescription
	{
		string Name { get; set; }
		string Desciption { get; set; }
		
		void Setup();
	}
}