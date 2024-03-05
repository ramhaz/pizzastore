using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace pizzastore
{

    public class Order
    {
        public Pizza Pizza { get; set; }
        public Customer Customer { get; set; }

        private decimal TaxRate = 1.25M;
        private decimal DeliveryCost = 40;

        public Order(Pizza pizza, Customer customer)
        {
            Pizza = pizza;
            Customer = customer;
        }

        public decimal CalculateTotalPrice()
        {
            return Pizza.Price + (Pizza.Price + TaxRate) + DeliveryCost;

        }

        public override string ToString()
        {
            return $" order {Pizza.Name}, Customer: {Customer.Name}, total price: {CalculateTotalPrice()}";
        }




        #region instance field







        #endregion

        #region constructor 

        #endregion

        #region propporties 




        #endregion

        #region methods 





        #endregion

    }

}
