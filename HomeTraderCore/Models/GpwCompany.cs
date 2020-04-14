using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTraderCore.Models
{
    public class GpwCompany
    {
        [Key]
        [Required]
        public int Id { get; set; }
       
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Ticker")]
        public string Ticker { get; set; }

        [Display(Name = "Index")]
        public string Index { get; set; }

        [Display(Name = "ISIN")]
        public string ISIN { get; set; }
    }
}
