using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BDDish.German;

namespace BDDish.Tests
{
	public class PlaygroundDSLGerman
	{
		[Test]
		public void Foo()
		{
			new German.Feature("Schnittstellen").
					Anforderung("FANTASYformat v1.0 exportieren").
						Als(SampleKunde.NormalerKunde).
							AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
								Für(SampleData.A).
								Gilt(SomeAssertionMethod).
								Gilt(SomeAssertionMethod, "").
							AkzeptanzKriterium("...").
								Für(SampleData.B).
								Gilt(SomeAssertionMethod).
						Als(SampleKunde.Sondermann).
							AkzeptanzKriterium("Die Auftragseigenschaften sind vollständig im Zieldokument zu finden").
								Für(SampleData.A).
								Gilt("FeldA", Is.EqualTo("FeldB")).
								Gilt("FeldB", Is.EqualTo("FeldB")).

					Execute();
		}

		public void SomeAssertionMethod()
		{
			
		}

	}
}
