<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public int ID { get; set; }
        [Required]
        [Display(Name="Category Name")]
        public string Name { get; set; }

        public IList<Cheese> Cheeses { get; set; }
    }
}
=======
﻿namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public string Name { get; set; }        
        public int ID { get; set; }
    }
}
>>>>>>> 7c21f3c46df186f6346b29ea49eefef6b0dc594b
