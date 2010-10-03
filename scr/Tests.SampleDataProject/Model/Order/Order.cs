using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
	public class Order
	{
		public int Id;
		
		public Buyer Buyer;
		public Seller Seller;

		public Positions Positions ;

		public decimal TotalPrice { get { return Positions.GetTotalPrice(); } }

	}
}
