﻿using System.Collections.Generic;
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
								Für(Sample.Order3Positions).
								Gilt(SomeAssertionMethod).
							AkzeptanzKriterium("...").
								Für(Sample.Order1Position).
								Gilt(SomeAssertionMethod).
						Als(Auftraggeber.Sondermann).
							AkzeptanzKriterium("Die Auftragseigenschaften sind vollständig im Zieldokument zu finden").
								Für(Sample.Order3Positions).
								Gilt(Sample.Order3Positions.Positions.Count, Is.EqualTo(3)).
								Gilt(Sample.Order3Positions.Positions[0].Price, Is.EqualTo(22m)).

					Execute();
		}

		public void SomeAssertionMethod()
		{
			
		}

	}
}
