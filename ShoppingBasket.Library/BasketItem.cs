using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    /// <summary>
    /// Not following SOLID Design Principles
    /// Not open for extension but open for modification - OCP Fail
    /// Creates dependency on this Class wherever referenced - DIP Fail
    /// </summary>
    public class BasketItem
    {
        public decimal Price
        {
            get; set;
        }

        public string ProductName
        {
            get; set;
        }

        public int Quantity
        {
            get; set;
        }
    }
}
