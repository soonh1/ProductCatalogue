using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogue.Models
{
    public class Type
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeID { get; set; }
        public string Title { get; set; }

        public ICollection<Gender> Genders { get; set; }
    }
}
