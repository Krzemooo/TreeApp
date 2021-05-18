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
        public string ItemValue { get; set; }
        public int ItemLevel { get; set; }
        public int ItemPosition { get; set; }
        public Guid UniqItemID { get; set; }
        public Guid? ParentUniqID { get; set; }
    }
}
