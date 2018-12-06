using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{

    public interface IBasket
    {
        List<IBasketItem> BasketItems { get; }

        void AddItem(IBasketItem basketItem);

        decimal Total();
    }
}
