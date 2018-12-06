using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    /// OCP Pass
    /// DIP Pass
    /// Could have been an abstract class but I've chosed Interface for better extensibility 
    public interface IBasketItem
    {
        string ProductName { get; set; }
        int Quantity { get; set; }
        decimal Price { get; set; }
    }
}
