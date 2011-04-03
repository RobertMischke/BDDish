using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDish.Model;

namespace BDDish.Tests
{
    public class Customers
    {
        public static ICustomerDescription Normal { get { return new CustomerNormal(); } }
        public static ICustomerDescription Special { get { return new CustomerSpecial(); } }
    }
}
