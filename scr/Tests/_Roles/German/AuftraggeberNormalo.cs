namespace BDDish.Tests
{
	public class AuftraggeberNormalo : ICustomerDescription
	{
		public string Name { get; set; }
		public string Desription { get; set; }

		public AuftraggeberNormalo()
		{
			Name = GetType().Name;
		}
	}
}