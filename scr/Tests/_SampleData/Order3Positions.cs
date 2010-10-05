using System;
using BDDish.Tests.SampleData;

namespace BDDish.Tests
{
	public class Order3Positions : IContextDescription 
	{
		public string Label { get; set; }
		public string SampleDesciption { get; set; }

		public Order Order;
		public PositionList Positions;
		public Buyer Buyer;
		public Seller Seller;

		public void Setup()
		{
			Order = new Order
			        	{
			        		Positions = Positions,
							Buyer = Buyer = new Buyer{Id = 1, Name = "BuyerName-A"},
							Seller = Seller = new Seller { Id = 1, Name = "SellerName-B" }
			        	};

			Positions = new PositionList
			            	{
			            		new Position {Id = 1, Price = 22.0m},
			            		new Position {Id = 2, Price = 47.3m},
			            		new Position {Id = 3, Price = 55.3m}
			            	};
		}

		public Order3Positions()
		{
			Label = "SampleOrderA";
			SampleDesciption =
				@"3 Positionen
				Position1: Id = 1
				Position2: Id = 2
				Position3: Id = 3

				Auftraggeber.Id = 1
				Auftraggeber.Name = Irgendeinname";
		}

	}
}