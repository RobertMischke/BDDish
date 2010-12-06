using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Visualizer
{
    public class TextFormatingIdentifier
    {
        public bool IsCamelCaseText(string text)
        {
            return !IsUnderScoreText(text);
        }

        public bool IsUnderScoreText(string text)
        {
            int count = text.ToCharArray().Where(character => character == '_').Count();

            if (count > 0)
                return true;

            return false;
        }
    }
}
