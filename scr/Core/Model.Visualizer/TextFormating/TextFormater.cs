using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Visualizer
{
    public class TextFormater
    {
        public string GetText(string text)
        {
            var textFormatIdentifier = new TextFormatingIdentifier();

            if (textFormatIdentifier.IsUnderScoreText(text))
                return new UnderscoresToText().GetText(text);

            if (textFormatIdentifier.IsCamelCaseText(text))
                return new CamelCaseToText().GetText(text);

            throw new Exception("unidentified formater");
        }
    }
}
