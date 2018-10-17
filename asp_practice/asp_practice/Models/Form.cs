using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_POSR_MVC.Models
{
    public class Form
    {
        [Key]
        public int Form_ID { get; set; }

        [StringLength(50)]
        public string Form_Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(50)]
        public string File_Name { get; set; }

        public int Display_Seq { get; set; }
    }
}
