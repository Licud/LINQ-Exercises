<Query Kind="Program" />

/* LINQ Looking for one item. */

class Order{
	public int Id {get;set;}
	public decimal Amount {get;set;}
	public string CustomerName{get;set;}
	
}

List<Order> orders = new List<Order>()
{
	new Order{Id = 123, Amount = 29.95m, CustomerName = "Mark"},
	new Order{Id = 456, Amount = 45.00m, CustomerName = "Steph"},
	new Order{Id = 768, Amount = 32.50m, CustomerName = "Claire"}
};

//void RefundOrder(int orderId){
//	Order orderToRefund = null;
//	
//	foreach(var order in orders){
//		if(order.Id == orderId){
//			orderToRefund = order;
//			break;
//		}
//	}
//	
//	Console.WriteLine("Refunding {0} to {1}",
//		orderToRefund.Amount,
//		orderToRefund.CustomerName);
//}

void RefundOrder(int orderId)
{
	// My solution, oops!
	//Order orderToRefund = orders.Where(c => c.Id == orderId).Single();
	
	// Better solution:
	Order orderToRefund = orders.FirstOrDefault(o => o.Id == orderId);
	
	Console.WriteLine("Refunding {0} to {1}",
		orderToRefund.Amount,
		orderToRefund.CustomerName);

}

void Main(){
	RefundOrder(456);
}

