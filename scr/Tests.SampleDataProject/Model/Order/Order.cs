using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDish.Tests.SampleData
{
	public class Order
	{
		public int Id;
		
		public Buyer Buyer;
		public Seller Seller;

		public PositionList PositionList ;

		public decimal TotalPrice { get { return PositionList.GetTotalPrice(); } }

	}
}
