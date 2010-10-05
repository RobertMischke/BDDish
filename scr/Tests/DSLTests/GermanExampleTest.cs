using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BDDish.German;

namespace BDDish.Tests
{
	public class GermanExampleTest
	{
		[Test]
		public void ExampleTest()
		{
			new German.Feature("Schnittstellen").
					Anforderung("FANTASYformat v1.0 exportieren").
						Als(Auftraggeber.Normalo).
							AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
								Für(Context1()).
								Gilt(SomeAssertionMethod).
							AkzeptanzKriterium("...").
								Für(Context2()).
								Gilt(SomeAssertionMethod).
						Als(Auftraggeber.Sondermann).
							AkzeptanzKriterium("Die Auftragseigenschaften sind vollständig im Zieldokument zu finden").
								Für(Context2()).
								Gilt(context2.Positions.Count, Is.EqualTo(3)).
								Gilt(context2.Positions[0].Price, Is.EqualTo(22m)).

					Execute();
		}

		private EinExportiertesFANTASYformatDokumentfürMusterFirma1undMusterVorgang24 context1;
		private EinExportiertesFANTASYformatMit3PositionenUndMusterFirma1 context2;

		private EinExportiertesFANTASYformatDokumentfürMusterFirma1undMusterVorgang24 Context1(){
			return context1 = new EinExportiertesFANTASYformatDokumentfürMusterFirma1undMusterVorgang24();
		}

		private EinExportiertesFANTASYformatMit3PositionenUndMusterFirma1 Context2(){
			return context2 = new EinExportiertesFANTASYformatMit3PositionenUndMusterFirma1();
		}

		public void SomeAssertionMethod()
		{
			
		}

	}
}
