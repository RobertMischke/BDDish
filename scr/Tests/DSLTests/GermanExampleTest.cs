using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

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
                                Für(ContextCamelCase()).
                                Gilt(SomeAssertionMethodWithCamelCase).
                            AkzeptanzKriterium("...").
                                Für(Context_with_underscores()).
                                Gilt(Some_assertion_method_with_underscores).
                        Als(Auftraggeber.Sondermann).
                            AkzeptanzKriterium("Die Auftragseigenschaften sind vollständig im Zieldokument zu finden").
                                Für(Context_with_underscores()).
                                Gilt(context2.Positions.Count, Is.EqualTo(3)).
                                Gilt(context2.Positions[0].Price, Is.EqualTo(22m)).

                    Execute();
		}

		private EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24 context1;
		private EinExportiertesFANTASYFormatMit3PositionenUndMusterFirma1 context2;

		private EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24 ContextCamelCase(){
			return context1 = new EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24();
		}

		private EinExportiertesFANTASYFormatMit3PositionenUndMusterFirma1 Context_with_underscores(){
			return context2 = new EinExportiertesFANTASYFormatMit3PositionenUndMusterFirma1();
		}

		public void SomeAssertionMethodWithCamelCase()
		{
		}

        public void Some_assertion_method_with_underscores()
        {
        }

	}
}
