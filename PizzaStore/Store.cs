using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {
        public void Start()
        {
            // Assuming Pizza, Customer, and Order classes are defined elsewhere within the PizzaStore namespace

            // Creating pizzas
            Pizza pizza1 = new Pizza("Margherita", 75m);
            Pizza pizza2 = new Pizza("Pepperoni", 85m);
            Pizza pizza3 = new Pizza("Hawaiian", 80m);

            // Creating customers
            Customer customer1 = new Customer("Hans Andersen", "Elmetoften 23");
            Customer customer2 = new Customer("Kirsten Magrethe", "Erdrupvej 87");
            Customer customer3 = new Customer("Steffen Jensen", "Kalundborgvej 3");

            // Creating orders
            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);

            // Printing order information
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
        }
    }
}


