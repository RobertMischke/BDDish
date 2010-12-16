using System;
using BDDish.Tests.SampleData;
using BDDish.Model;

namespace BDDish.Tests
{
	public class Order1Position : IContextDescription
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
				Positions = Positions = new PositionList {new Position{Id = 2, Price = 100m} },
				Buyer = Buyer = new Buyer { Id = 1, Name = "BuyerName-A" },
				Seller = Seller = new Seller { Id = 1, Name = "SellerName-B" }
			};
		}

		public Order1Position()
		{
			SampleDesciption =
				@"
				Nur kleine Variation zu SampleOrderA

				3 Positionen
				Position1: Id = 1
				Position2: Id = 2
				Position3: Id = 3

				Auftraggeber.Id = 1
				Auftraggeber.Name = Irgendeinname";
		}
	}
}