using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSharpProject
{
    class Supplier
    {
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public Supplier(string name, int supplierId)
        {
            Name = name;
            SupplierId = supplierId;
        }
    }
}
