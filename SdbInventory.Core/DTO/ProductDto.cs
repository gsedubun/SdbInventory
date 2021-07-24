using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SdbInventory.Core.DTO
{
    public sealed class ProductDto
    {
        [Key]
        public int ID { get; set; }

    }
}
