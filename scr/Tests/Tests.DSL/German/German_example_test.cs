﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests
{
    /// <summary>
    /// No assertions. To inspect output and see usage.
    /// </summary>
	public class German_example_test
	{
		[Test]
		public void Example_test_with_multiple_nonsense_combinations()
		{
            new German.Feature("Schnittstellen").Bemerkung("Work in Progress ").
                    Beschreibung("Eine nähere Beschreibung des Features").
                    Anforderung("FANTASYformat v1.0 exportieren").
                        Als(Auftraggeber.Normalo).
                            AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
                                Für(ContextCamelCase).
                                    Und(Weitere_action_fuer_context).
                                    Und(Weitere_action_fuer_context).
                                    Dann(Weitere_action_fuer_context).
                                Gilt(SomeAssertionMethodWithCamelCase).
                            AkzeptanzKriterium("...").
                                Wenn(Context_with_underscores).
                                Gilt(Some_assertion_method_with_underscores).
                            AkzeptanzKriterium("...").
                                GegebenIst(ContextCamelCase).
                                    Dann(Weitere_action_fuer_context).
                                Soll(SomeAssertionMethodWithCamelCase).
                        Als(Auftraggeber.Sondermann).
                            AkzeptanzKriterium("Die Auftragseigenschaften sind vollständig im Zieldokument zu finden").
                                Für(Context_with_underscores).
                                Gilt(() => context2.Positions.Count , () => Is.EqualTo(3)).
                                Gilt(() => context2.Positions[0].Price, () => Is.EqualTo(22m)).
                            AkzeptanzKriterium("Ein weiteres noch nicht spezifiziertes Kriterium ").
                            AkzeptanzKriterium("Und noch eins").
                            AkzeptanzKriterium("Und noch eins nur mit Tests").
                                Test(Hier_die_Ausführung).
                                Test(Hier_die_Ausführung).
                            AkzeptanzKriterium("..").
                                Test(Hier_die_Ausführung).
                    Execute(this);
		}


	    private EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24 context1;
		private EinExportiertesFANTASYFormatMit3PositionenUndMusterFirma1 context2;
		private EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24 ContextCamelCase(){
			return context1 = new EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24();
		}

        private void Weitere_action_fuer_context()
        {
        }

		private EinExportiertesFANTASYFormatMit3PositionenUndMusterFirma1 Context_with_underscores(){
			return context2 = new EinExportiertesFANTASYFormatMit3PositionenUndMusterFirma1();
		}

		public void SomeAssertionMethodWithCamelCase(){}
        public void Some_assertion_method_with_underscores(){}
        private void Hier_die_Ausführung() { }

	}
}
