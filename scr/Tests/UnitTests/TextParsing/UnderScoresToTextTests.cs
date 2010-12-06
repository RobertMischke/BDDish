using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model.Visualizer;
using NUnit.Framework;

namespace BDDish.Tests
{
    [TestFixture]
    public class UnderScoresToTextTests
    {
        private readonly UnderscoresToText _underscoresToText = new UnderscoresToText();

        [Test]
        public void Underscore_string_to_text()
        {
            Assert.That(_underscoresToText.GetText("Some_great_text"), Is.EqualTo("Some great text"));
        }
    }
}
