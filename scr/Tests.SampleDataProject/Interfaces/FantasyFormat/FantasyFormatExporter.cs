using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using BDDish.Tests.SampleData;

namespace BDDish.Tests.SampleData
{
	public class FantasyFormatExporter
	{
		public void Run(Order order, string pfad)
		{
			Run(new FantasyFormatExporterCommand {Order = order, OutputPath = pfad});
		}

		public void Run(FantasyFormatExporterCommand cmd)
		{
			var auftrag = cmd.Order;

			var xDoc = new XDocument(
				new XElement("Auftrag",
					new XElement("Id", auftrag.Id),
					new XElement("Käufer",
						new XElement("Id", auftrag.Buyer.Id),
						new XElement("Name", auftrag.Buyer.Name)),
					new XElement("Verkäufer",
						new XElement("Id", auftrag.Seller.Id),
						new XElement("Name", auftrag.Seller.Name)),
					new XElement("Positionen"),
						auftrag.Positions.Select(pos => new XElement("Position",
								new XElement("Id", pos.Id),
								new XElement("Preis", pos.Price))
							)));

			xDoc.Save(cmd.OutputPath);
		}

	}
}
