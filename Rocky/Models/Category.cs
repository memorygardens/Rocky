using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        //uses entiy framework to create the id similar to how sql creates id's.
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }


    }
}
