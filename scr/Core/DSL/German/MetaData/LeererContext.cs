using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.DSL.German.MetaData
{
    public class LeererContext : EmptyContextBase
    {
        public LeererContext(Action action) : base(action, "")
        {
        }
    }
}
