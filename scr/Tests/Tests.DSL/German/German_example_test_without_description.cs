using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests
{
    public class German_example_test_without_description
    {
        [Test]
        public void Example_test_without_description()
        {
            new German.Feature("Schnittstellen").
                    Anforderung("FANTASYformat v1.0 exportieren").
                        Als(Auftraggeber.Normalo).
                            AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
                                Für(ContextCamelCase).
                                Gilt(SomeAssertionMethodWithCamelCase).
                Execute(this);
        }

        private EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24 ContextCamelCase(){
            return new EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24();
        }

        public void SomeAssertionMethodWithCamelCase() { }

    }
}
