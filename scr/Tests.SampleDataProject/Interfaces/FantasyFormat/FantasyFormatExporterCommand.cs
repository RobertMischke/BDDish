using Core.Model;

namespace Core.Schnittstellen
{
	public class FantasyFormatExporterCommand
	{
		public Order Order;
		public string OutputPath = "out.xml";
	}
}