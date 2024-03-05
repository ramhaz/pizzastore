using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzastore
{
    public class store
    {
        public void Start()
        {

            Pizza pizza1 = new Pizza("Margherita", 12);
            Pizza pizza2 = new Pizza("Pepporoni", 19);
            Pizza pizza3 = new Pizza("Hawai", 24);

            // proccede to make customers 

            Customer customer1 = new Customer("Lucas");
            Customer customer2 = new Customer("Mikkel");
            Customer customer3 = new Customer("Albert");


            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);

            //printing order
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);




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
}
