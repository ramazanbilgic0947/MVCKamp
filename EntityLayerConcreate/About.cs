using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EntityLayer.Concreate
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
       
        [StringLength(250)]
        public string AboutDeails1 { get; set; }
        [StringLength(250)]
        public string AboutDeails2 { get; set; }
        [StringLength(120)]
        public string AboutImage1 { get; set; }
        [StringLength(120)]
        public string AboutImage2 { get; set; }



    }
}
