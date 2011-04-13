using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests.DSLTests
{
    public class German_example_with_note
    {
        [Test]
        public void Example_test_with_notes()
        {
            new German.Feature("Schnittstellen").
                    Anforderung("FANTASYformat v1.0 exportieren").Bemerkung("Anforderung - Bemerkung").
                        Als(Auftraggeber.Normalo).Bemerkung("Als - Bermerkung").
                            AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").Bemerkung("Aktzeptanzkriterium - Bemerkung").
                                Für(ContextCamelCase).Bemerkung("Für - Bemerkung").
                                Gilt(SomeAssertionMethodWithCamelCase).
                Execute(this);
        }

        private EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24 ContextCamelCase(){
            return new EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24();
        }

        public void SomeAssertionMethodWithCamelCase() { }
    }
}
