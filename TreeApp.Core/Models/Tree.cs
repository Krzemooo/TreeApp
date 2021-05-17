using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TreeApp.Core.Models
{
    public class Tree
    {
        [Key]
        public int ID { get; set; }
        public Item Item { get; set; }
        public int ItemLevel { get; set; }
        public int? ItemParent { get; set; }
    }
}
