using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EntityLayer.Concreate
{
    public class Writer
    {[Key]
        public int WriterID { get; set; }
        [StringLength(40)]
        public string WriterName { get; set; }
        [StringLength(20)]
        public string WriterSurnames { get; set; }
        [StringLength(120)]
        public string WriterImage { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(25)]
        public string WriterPassword { get; set; }
       
        public ICollection<Heading> Headings { get; set; }
       public ICollection<Content> Contents { get; set; }



    }
}
