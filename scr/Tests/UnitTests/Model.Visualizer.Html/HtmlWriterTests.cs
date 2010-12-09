using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BDDish.Model.Concept;

namespace BDDish.Tests
{
    [TestFixture]
    public class HtmlWriterTests
    {
        [Test]
        public void Html_writer_should_write_file()
        {
            var writer = new HtmlWriter();
            writer.Write(new Feature("labelConcept", "labelBody"));

            //Assert.That(File.Exists("report.html"), "Report Datei sollte geschrieben sein.");
        }
    }
}
