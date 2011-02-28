using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BDDish.Model.Visualizer;

namespace BDDish.Tests
{
    public class TextFormatIdentifierTests
    {
        [Test]
        public void Should_identify_camel_case_text()
        {
            var formatingIdentifier = new TextFormatingIdentifier();
            Assert.That(formatingIdentifier.IsCamelCaseText("fooBarTest"), Is.True);
            Assert.That(formatingIdentifier.IsCamelCaseText("foo_bar_test"), Is.False);
        }
        
        [Test]
        public void Should_identify_underscore_text()
        {
            var formatingIdentifier = new TextFormatingIdentifier();
            Assert.That(formatingIdentifier.IsUnderScoreText("fooBarTest"), Is.False);
            Assert.That(formatingIdentifier.IsUnderScoreText("foo_bar_test"), Is.True);            
        }
    }
}
