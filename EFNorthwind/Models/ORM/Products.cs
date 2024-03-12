using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwind.Models.ORM
{
    public class Products:BaseModel
    {
        [MaxLength(40)]
        public string ProductName { get; set; }

        [MaxLength(20)]
        public string? QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsInOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int? SupplierId { get; set; }
        public Suppliers? Supplier { get; set; }
        public int? CategoryId { get; set; }
        public Categories? Category { get; set; }
    }
}
