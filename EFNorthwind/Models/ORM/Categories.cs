using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwind.Models.ORM
{
    public class Categories : BaseModel
    {
        [MaxLength(15)]
        public string CategoryName { get; set; }

        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
    }
}
