using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Visualizer;
using NUnit.Framework;

namespace BDDish.Tests
{
    public class TextFormaterTests
    {
        [Test]
        public void Text_formater_should_identify_underscore_or_camel_case_text()
        {
            var textFormater = new TextFormater();

            Assert.That(textFormater.GetText("Hello_world_format_me_well"), Is.EqualTo("Hello world format me well"));
            Assert.That(textFormater.GetText("HelloWorldFormatMeWell"), Is.EqualTo("Hello world format me well"));
        }
    }
}
