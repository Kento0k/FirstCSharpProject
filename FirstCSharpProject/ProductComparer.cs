using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSharpProject
{
    class ProductNameComparer:IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
