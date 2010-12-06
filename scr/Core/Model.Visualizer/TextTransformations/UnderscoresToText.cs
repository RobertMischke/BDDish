using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Model.Visualizer
{
    public class UnderscoresToText
    {
        public string GetText(string underscoreText)
        {
            return underscoreText.Replace('_', ' ');
        }
    }
}
