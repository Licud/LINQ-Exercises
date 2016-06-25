<Query Kind="Statements" />

/* LINQ to find matching element(s) */

var customers = new[]{
	new {Name = "Annie", Email = "annie@test.com" },
	new {Name = "Bob", Email = "" },
	new {Name = "Charles", Email = "charles@test.com" },
	new {Name = "Daniel", Email = "daniel@test.com" }
};

//foreach(var customer in customers)
//{
//	if(!String.IsNullOrEmpty(customer.Email))
//	{
//		Console.WriteLine("Sending email to {0}", customer.Name);
//	}
//}

foreach(var customer in customers.Where(c => !String.IsNullOrEmpty(c.Email))){
	Console.WriteLine("Sending email to {0}", customer.Name);
}