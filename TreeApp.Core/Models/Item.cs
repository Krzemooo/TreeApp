using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TreeApp.Core.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string ItemTitle { get; set; }
        public string ItemContent { get; set; }
    }
}
