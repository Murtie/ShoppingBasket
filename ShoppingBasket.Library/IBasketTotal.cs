using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    /// OCP Pass
    /// DIP Pass
    /// ISP Pass - No longer forcing multiple methods
    public interface IBasketTotal
    {
        decimal Total();
    }
}