using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a

namespace CodingEventsDemo.ViewModels
{
    public class AddEventCategoryViewModel
    {
<<<<<<< HEAD
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
=======
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters long")]
>>>>>>> 273616482705bf23682333d0e67a55344a2dd55a
        public string Name { get; set; }
    }
}
