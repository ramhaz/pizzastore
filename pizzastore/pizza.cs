﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzastore
{
    public class Pizza
    {
        public string Name { get; set; }    
        public decimal Price { get; set; }

        public Pizza(string name, decimal price) 
        { 
            Name = name;
            Price = price;

        }
         
        public override string ToString() 
        {
            return $"{Name} {Price:x2}";
        
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
