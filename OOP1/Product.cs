using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //id
        public int Id { get; set; }
        //urunadi
        public string ProductName { get; set; }
        //urunfiyat
        public double UnitPrice { get; set; }
        //stokAdedi
        public int UnitsIntStock { get; set; }

        public int CategoryId { get; set; }

    }
}
