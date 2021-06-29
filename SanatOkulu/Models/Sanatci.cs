using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatOkulu.Models
{
    [Table("Sanatcilar")]
    public class Sanatci
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        // virtual koyduğunuzda bu navigation property'de
        // LAZY LOADING aktif olur. Bu sanatçının birden çok eseri olabilir
        public virtual ICollection<Eser> Eserler { get; set; }
    }
}
