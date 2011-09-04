using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BDDish.Tests.Tests.DSL.German
{
    public class German_example_without_aceptance_criteria
    {

        [Test]
        public void Example_test_without_description()
        {
            new BDDish.German.Feature("Schnittstellen").
                    Anforderung("Ein erstelltes DO").
                        Als(Auftraggeber.Normalo).
                            AkzeptanzKriterium("Das erstellte Dokument ist gegen XSD zu validieren").
                                Für(ContextCamelCase).
                                Gilt(SomeAssertionMethodWithCamelCase).
                Execute(this);
        }

        private EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24 ContextCamelCase()
        {
            return new EinExportiertesFANTASYFormatDokumentFürMusterFirma1UndMusterVorgang24();
        }

        public void SomeAssertionMethodWithCamelCase() { }

    }
}
