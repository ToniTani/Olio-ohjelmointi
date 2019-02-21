using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    interface IProducts
    {
        void AddProduct(List<Product> product);
        void PrintProducts();
    }
}
