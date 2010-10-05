namespace BDDish.Tests
{
	public class AuftraggeberSondermann : ICustomerDescription
	{
		public string Name { get; set; }
		public string Desription { get; set; }

		public AuftraggeberSondermann()
		{
			Name = GetType().Name;
		}
	}
}