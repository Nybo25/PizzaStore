using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    public Pizza Pizza { get; set; }
    public Customer Customer { get; set; }
    public decimal TotalPrice => CalculateTotalPrice();

    public Order(Pizza pizza, Customer customer)
    {
        Pizza = pizza;
        Customer = customer;
    }

    private decimal CalculateTotalPrice()
    {
        const decimal taxAndDeliveryCost = 40m;
        return Pizza.Price + taxAndDeliveryCost;
    }

    public override string ToString()
    {
        return $"Order for {Customer.Name}, Address: {Customer.Address}, Pizza: {Pizza.Name}, Total Price: {TotalPrice} kr";
    }
}


