using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Core.Model;

namespace Core.Schnittstellen
{
	public class FantasyFormatExporter
	{

		public void Run(Auftrag auftrag, string pfad)
		{
			Run(new FantasyFormatExporterCommand {Auftrag = auftrag, OutputPath = pfad});
		}

		public void Run(FantasyFormatExporterCommand cmd)
		{
			var auftrag = cmd.Auftrag;

			var xDoc = new XDocument(
				new XElement("Auftrag",
					new XElement("Id", auftrag.Id),
					new XElement("Käufer",
						new XElement("Id", auftrag.Käufer.Id),
						new XElement("Name", auftrag.Käufer.Name)),
					new XElement("Verkäufer",
						new XElement("Id", auftrag.Verkäufer.Id),
						new XElement("Name", auftrag.Verkäufer.Name)),
					new XElement("Positionen"),
						auftrag.Positionen.Select(pos => new XElement("Position",
								new XElement("Id", pos.Id),
								new XElement("Preis", pos.Preis))
							)));

			xDoc.Save(cmd.OutputPath);
		}

	}
}
