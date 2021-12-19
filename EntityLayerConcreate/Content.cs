using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EntityLayer.Concreate
{
  public  class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(950)]
        public string ContenValue { get; set; }

        public DateTime ContentDate { get; set; }
        //contentyazar(Bu yazı kim tarafından yazıldı)
        //ContentBaşlık
        public int HeadingID { get; set; }
        public virtual Heading Heading_Baslik { get; set; }// heading tablomuzda burayla
                                                           //ilişkili olduğu için buraya da
                                                           //heading tablomuzu ilişkilendirdik

        public int? WriterID { get; set; }
       public virtual Writer Writer { get; set; }
    }
}
