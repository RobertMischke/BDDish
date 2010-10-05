﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BDDish.German;

namespace BDDish.Tests
{
	public class PlaygroundDSLGerman
	{
		[Test]
		public void SampleTest()
		{
			new German.Feature("Schnittstellen").
					Anforderung("FANTASYformat v1.0 exportieren").
						Als(Auftraggeber.Normalo).
							AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
								Für(SampleData.OrderA).
								Gilt(SomeAssertionMethod).
								Gilt(SomeAssertionMethod, "").
							AkzeptanzKriterium("...").
								Für(SampleData.OrderB).
								Gilt(SomeAssertionMethod).
						Als(Auftraggeber.Sondermann).
							AkzeptanzKriterium("Die Auftragseigenschaften sind vollständig im Zieldokument zu finden").
								Für(SampleData.OrderA).
								Gilt(SampleData.OrderA.Name , Is.EqualTo("Name")).
								Gilt("FeldB", Is.EqualTo("FeldB")).

					Execute();
		}

		public void SomeAssertionMethod()
		{
			
		}

	}
}
